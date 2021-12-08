# Game-Of-Life
Windows Forms Application  implementing the simulation: "Game of life (Life, The game of life)" - one of the first and most famous examples of a Cellular Automaton
* <b>Space dimension:</b>: 2D
* <b>Neighborhood</b>: Moore
* <b>Available states</b>: 2: "alive" or "dead"
* <b>Transition rules:</b>
  * Every dead cell (state 0) with three living neighbors (cells in state 1) is born (changes its state from 0 to 1)
  * Any living cell that has two or three living neighbors (cells in state 1) remains alive (maintains state 1)
  * Every living cell with more than 3 neighbors dies of "hunger"
  * Every living cell with fewer than two neighbors dies too, from "loneliness"

![image35](https://user-images.githubusercontent.com/60195641/143957894-0103541d-99fc-4dab-9b06-dce8129c351c.png)

We can choose from 4 different initial states:

Unchanging  |     Glider    |   Oscylator   |    Random     |     Custom    |
------------- | ------------- | ------------- | ------------- | ------------- |
 ![image37](https://user-images.githubusercontent.com/60195641/143959130-990fd174-d76c-4b32-9a5f-4f6144c3e153.png) | ![image26](https://user-images.githubusercontent.com/60195641/143959023-973eefa6-1b09-46a9-a7c4-8eff1e741569.png) | ![image17](https://user-images.githubusercontent.com/60195641/143959040-4c299905-3496-4606-9545-06f21cf3fa5c.png) | ![image34](https://user-images.githubusercontent.com/60195641/143959054-fdce5dad-7d0e-4f90-8cef-f18851dd516e.png) | ![image19](https://user-images.githubusercontent.com/60195641/143959072-ca3e06b9-e6a8-4363-88ee-e7b117257c48.png)  |

Examples of simulation results:

![Bez tytułu](https://user-images.githubusercontent.com/60195641/143959910-7a6ac706-aa9d-434b-bb4e-ffd5230565f3.png)

------------------------------------------------------------------------------------------------------------------

Aplikacja napisana używając Windows Forms implementująca symulację: "Gra w życie (Life, The game of life)" - czyli jeden z pierwszych i najbardziej znanych przykładów automatu komórkowego
* <b>Wymiar przestrzeni</b>: 2D
* <b>Sąsiedztwo</b>: Moore
* <b>Dostępne stany</b>: 2: „żywa” lub „martwa”
* <b>Reguły przejścia:</b>
  * Każda martwa komórka (stan 0),posiadająca trzech żywych sąsiadów(komórki w stanie 1), rodzi się(zmienia swój stan z 0 na 1)
  * Każda żywa komórka posiadająca dwóch lub trzech żywych sąsiadów (komórki w stanie 1), pozostaje żywą (utrzymuje stan 1)
  * Każda żywa komórka posiadająca więcej niż 3 sąsiadów umiera, z “głodu”
  * Każda żywa komórka posiadająca mniej niż dwóch sąsiadów również umiera, z “samotności”


![image35](https://user-images.githubusercontent.com/60195641/143957894-0103541d-99fc-4dab-9b06-dce8129c351c.png)

Do wyboru mamy między innymi 4 różne stany początkowe:

  Niezmienne  |     Glider    |   Oscylator   |    Losowy     |     Custom    |
------------- | ------------- | ------------- | ------------- | ------------- |
 ![image37](https://user-images.githubusercontent.com/60195641/143959130-990fd174-d76c-4b32-9a5f-4f6144c3e153.png) | ![image26](https://user-images.githubusercontent.com/60195641/143959023-973eefa6-1b09-46a9-a7c4-8eff1e741569.png) | ![image17](https://user-images.githubusercontent.com/60195641/143959040-4c299905-3496-4606-9545-06f21cf3fa5c.png) | ![image34](https://user-images.githubusercontent.com/60195641/143959054-fdce5dad-7d0e-4f90-8cef-f18851dd516e.png) | ![image19](https://user-images.githubusercontent.com/60195641/143959072-ca3e06b9-e6a8-4363-88ee-e7b117257c48.png)  |

Przykładowe wyniki symulacji:


![Bez tytułu](https://user-images.githubusercontent.com/60195641/143959910-7a6ac706-aa9d-434b-bb4e-ffd5230565f3.png)




