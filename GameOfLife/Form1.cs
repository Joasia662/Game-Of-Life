using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GameOfLife
{
    public partial class Form1 : Form
    {


        Boolean firstuse = true;
        int[,] matrix_custom = new int[148, 148];
        int pixcelWidthCount ;
        int pixcelHeightCount;

        int widithCount;
        int heightCount;

        int[,] final;

        void fill_matrix_custom(int [,] grid)
        {
            for (int i = 0; i < 37; i++)
            {
                for (int j = 0; j < 37; j++)
                {
                    matrix_custom[i, j] = 0;
                
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            this.cbWidth.SelectedIndex = 2;
            this.cbHeight.SelectedIndex = 2;
            
            setPixcelAmount();
            create_grid(pixcelWidthCount, pixcelHeightCount);
            
            widithCount = Convert.ToInt32(this.cbWidth.SelectedItem);
            heightCount = Convert.ToInt32(this.cbHeight.SelectedItem);
            this.cbTypeOfGrid.SelectedIndex = 3;
        }

        private void btnResizeGrid_Click(object sender, EventArgs e)
        {
            Refresh();
            setPixcelAmount();
            create_grid(pixcelWidthCount, pixcelHeightCount);
            widithCount = Convert.ToInt32(this.cbWidth.SelectedItem);
            heightCount = Convert.ToInt32(this.cbHeight.SelectedItem);
            int tmp_index = this.cbTypeOfGrid.SelectedIndex;

            if (this.cbTypeOfGrid.SelectedIndex != 4 && this.cbTypeOfGrid.SelectedIndex != 3) this.cbTypeOfGrid.SelectedIndex = this.cbTypeOfGrid.SelectedIndex++ ;
            else this.cbTypeOfGrid.SelectedIndex = this.cbTypeOfGrid.SelectedIndex--;
            this.cbTypeOfGrid.SelectedIndex = tmp_index;
        }


       
     
        private void pic_Click(object sender, EventArgs e)
        {

        }



        void create_grid(int w, int h)
        {
           
                pic.Image = new Bitmap(pic.Width, pic.Height);
                for (int y = 0; y < pic.Height; y += h)
                {
                    int pic_x = 0;
                    while (pic_x < pic.Width)
                    {

                        ((Bitmap)pic.Image).SetPixel(pic_x, y, Color.FromArgb(0, 0, 0));
                        pic_x++;

                    }

                }

                for (int x = 0; x < pic.Width; x += w)
                {
                    int pic_y = 0;
                    while (pic_y < pic.Height)
                    {

                        ((Bitmap)pic.Image).SetPixel(x, pic_y, Color.FromArgb(0, 0, 0));
                        pic_y++;

                    }
                }
            
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            firstuse = true;
            if (this.cbTypeOfGrid.SelectedItem == "Custom")
            {
                //--------------------------------------- CREATING A GRID ---------------------------------------------

                pic.Image = new Bitmap(pic.Width, pic.Height);

            for (int y = 0; y < pic.Height; y += pixcelHeightCount)
            {
                int pic_xx = 0;
                while (pic_xx < pic.Width)
                {

                    ((Bitmap)pic.Image).SetPixel(pic_xx, y, Color.FromArgb(0, 0, 0));
                    pic_xx++;

                }

            }

            for (int x = 0; x < pic.Width; x += pixcelWidthCount)
            {
                int pic_yy = 0;
                while (pic_yy < pic.Height)
                {
                    ((Bitmap)pic.Image).SetPixel(x, pic_yy, Color.FromArgb(0, 0, 0));
                    pic_yy++;

                }
            }
 



            //**************************************** GET MATRIX CUSTOM POINT LOCATION  **************************
           
            
            int event_loc_x = e.Location.X;
            int event_loc_y = e.Location.Y;

            int mod_x = event_loc_x % pixcelWidthCount;
                int mod_y = event_loc_y % pixcelHeightCount;

            int matrix_x_index = Math.Abs(event_loc_x - mod_x) / pixcelWidthCount;
                int matrix_y_index = Math.Abs(event_loc_y - mod_y) / pixcelHeightCount;

            if (matrix_custom[matrix_x_index, matrix_y_index] == 1) matrix_custom[matrix_x_index, matrix_y_index] = 0;
            else matrix_custom[matrix_x_index, matrix_y_index] = 1;




            // &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& FILL MATRIX POINTS &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

           
            for (int i = 0; i < widithCount; i++)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    if (matrix_custom[i, j] == 1)
                    {

                        for (int x = pixcelHeightCount * j; x < (pixcelHeightCount * j + pixcelHeightCount); x++) 
                        
                            for (int y = pixcelWidthCount * i ; y < (pixcelWidthCount * i + pixcelWidthCount); y++)
                            {

                                ((Bitmap)pic.Image).SetPixel(y, x, Color.FromArgb(0, 0, 0));
                            }
                        }
                    }
                }   
             }
            //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        }

        void draw_table(int[,] matrix_to_show)
        {

            pic.Image = new Bitmap(pic.Width, pic.Height);

            for (int y = 0; y < pic.Height; y += pixcelHeightCount)
            {
                int pic_xx = 0;
                while (pic_xx < pic.Width)
                {

                    ((Bitmap)pic.Image).SetPixel(pic_xx, y, Color.FromArgb(0, 0, 0));
                    pic_xx++;

                }

            }

            for (int x = 0; x < pic.Width; x += pixcelWidthCount)
            {
                int pic_yy = 0;
                while (pic_yy < pic.Height)
                {

                    ((Bitmap)pic.Image).SetPixel(x, pic_yy, Color.FromArgb(0, 0, 0));
                    pic_yy++;

                }
            }

            for (int i = 0; i < widithCount; i++)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    if (matrix_to_show[i, j] == 1)
                    {

                        for (int x = pixcelHeightCount * j; x < (pixcelHeightCount * j + pixcelHeightCount); x++)

                            for (int y = pixcelWidthCount * i; y < (pixcelWidthCount * i + pixcelWidthCount); y++)
                            {

                                ((Bitmap)pic.Image).SetPixel(y, x, Color.FromArgb(0, 0, 0));
                            }
                    }
                }
            }
            
        }


        void setPixcelAmount()
        {

            pixcelWidthCount = this.pic.Width / Convert.ToInt32(this.cbWidth.SelectedItem);
            pixcelHeightCount = this.pic.Height/ Convert.ToInt32(this.cbHeight.SelectedItem);

        }

        private void Action_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (firstuse == true)
            {
                if (this.cbTypeOfGrid.SelectedItem.ToString() != "Custom") final = logic.buildMatrix(this.cbTypeOfGrid.SelectedItem.ToString(), widithCount, heightCount);
                else final = create_matrix_custom();
                firstuse = false;
            }


            int[,] tmp_array;
            tmp_array = logic.create_new_array(final, widithCount, heightCount);

            final = tmp_array;
            draw_table(tmp_array);

            if (this.cbTypeOfGrid.SelectedItem.ToString() == "Custom")
            {
                send_value(final);
            }

        }


        void send_value(int[,] tmp)
        {
            for (int i = 0; i < widithCount; i++)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    matrix_custom[i, j] = tmp[i, j];
                }
            }
            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            Refresh();


        }

        void Refresh()
        {
            for (int i = 0; i <148; i++)
            {
                for (int j = 0; j < 148; j++)
                {

                    matrix_custom[i, j] = 0;

                }

            }
            create_grid(pixcelWidthCount, pixcelHeightCount);

        }

        private void cbTypeOfGrid_SelectedValueChanged(object sender, EventArgs e)
        {
            firstuse = true;
            int[,] matrix_to_show;
            if (this.cbTypeOfGrid.SelectedItem.ToString() != "custom")
            { matrix_to_show = logic.buildMatrix(this.cbTypeOfGrid.SelectedItem.ToString(), widithCount, heightCount); }
            else matrix_to_show = create_matrix_custom();

            final = matrix_to_show;
            draw_table(matrix_to_show);
           
            
         }

        int[,] create_matrix_custom()
        {
            int[,] tmp = new int [widithCount,heightCount];
            for (int i = 0; i < widithCount; i++)
            {
                for (int j = 0; j < heightCount; j++)
                {
                    tmp[i, j] = matrix_custom[i, j];
                }
            }
            return tmp;
        }




        private void Form1_Activated(object sender, EventArgs e)
        {
             
        }

        private void btnStart_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
