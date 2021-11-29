using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    static class logic
    {

        public static int[,] buildMatrix(String type,int widithCount, int heightCount)
        {
            int[,] matrix_to_show;

            switch (type)
            {
                case "niezmienne":
                    matrix_to_show = niezmienna(widithCount, heightCount);
                    break;

                case "glider":
                    matrix_to_show = glider(widithCount, heightCount);
                    break;

                case "oscylator":
                    matrix_to_show = oscylator(widithCount, heightCount);
                    break;

                case "random":
                    matrix_to_show = losowy(widithCount, heightCount);
                    break;

                default:
                    matrix_to_show = new int[148, 148];
                    //nothing
                    break;
            }

            return matrix_to_show;

        }

        public static int[,] niezmienna(int widithCount, int heightCount)
        {

            int[,] created_matrix = new int[widithCount, heightCount];


            for (int i = 0; i < widithCount; ++i)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    created_matrix[i, j] = 0;
                }

            }

            int middle_x = widithCount / 2;
            int middle_y = heightCount / 2;

            middle_x--;
            middle_y--;

            created_matrix[middle_x, middle_y] = 1;
            created_matrix[middle_x + 1, middle_y] = 1;

            created_matrix[middle_x - 1, middle_y + 1] = 1;
            created_matrix[middle_x + 2, middle_y + 1] = 1;

            created_matrix[middle_x, middle_y + 2] = 1;
            created_matrix[middle_x + 1, middle_y + 2] = 1;

            return created_matrix;
        }

        public static int[,] glider(int widithCount, int heightCount)
        {

            int[,] created_matrix = new int[widithCount, heightCount];


            for (int i = 0; i < widithCount; ++i)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    created_matrix[i, j] = 0;
                }

            }

            int middle_x = widithCount / 2;
            int middle_y = heightCount / 2;

            middle_x--;
            middle_y--;

            created_matrix[middle_x + 1, middle_y - 1] = 1;
            created_matrix[middle_x + 2, middle_y - 1] = 1;

            created_matrix[middle_x, middle_y] = 1;
            created_matrix[middle_x + 1, middle_y] = 1;


            created_matrix[middle_x + 2, middle_y + 1] = 1;

            return created_matrix;
        }



        public static int[,] oscylator(int widithCount, int heightCount)
        {

            int[,] created_matrix = new int[widithCount, heightCount];


            for (int i = 0; i < widithCount; ++i)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    created_matrix[i, j] = 0;
                }

            }

            int middle_x = widithCount / 2;
            int middle_y = heightCount / 2;

            middle_x--;
            middle_y--;

            created_matrix[middle_x, middle_y] = 1;
            created_matrix[middle_x, middle_y + 1] = 1;
            created_matrix[middle_x, middle_y + 2] = 1;

            return created_matrix;
        }


        public static int[,] losowy(int widithCount, int heightCount)
        {

            int[,] created_matrix = new int[widithCount, heightCount];
            int totalCount = widithCount * heightCount;
            totalCount = (totalCount / 3) * 2;
            int x;
            int y;

            for (int i = 0; i < totalCount; i++)
            {
                Random random = new Random();
                x = random.Next(0, widithCount - 1);
                y = random.Next(0, heightCount - 1);

                created_matrix[x, y] = 1;
                System.Threading.Thread.Sleep(5);

            }

            return created_matrix;
        }




        public static int neighbours(int x, int y, int[,] array, int width, int height)
        {
            int neibours_count = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (!(i < 0 || i >= width || j < 0 || j>= height))
                    {

                        if ((!(i==x && j ==y)) && array[i, j] == 1) neibours_count++;
                    }

                  
                } 
            }
          return neibours_count;
        }

        public static int[,]  create_new_array(int[,] array, int width,int height) {
           
            int[,] tmp = new int[width, height];

            
            for (int i = 0; i < width; i++) {
                for (int j = 0; j < height ; j++)
                {
                    int neibours_count = neighbours(i, j, array, width, height);

                    if (array[i, j] == 0)
                    {
                            if (neibours_count == 3)
                            tmp[i,j] = 1;
                            else
                            tmp[i,j] = 0;
                    }
                    else
                    {
                            if (neibours_count < 2 || neibours_count > 3)
                            tmp[i,j] = 0;
                            else
                            tmp[i,j] = 1;
                    }
                    
                } 
            }
                 
            return tmp;
        }

       
    }
}
