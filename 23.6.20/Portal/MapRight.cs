using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class MapRight
    {

        const int mapWidth = 20;
        const int mapLength = 15;
        string[,] field = new string[mapLength, mapWidth];


        string userInput = default;
        int playerPosX = default;
        int playerPosY = default;






        public void DoMapRight()
        {
            MakeMapRight_First();
            MakeMapRight_Move();
        }




        public void MakeMapRight_First()
        {
            for (int vertical = 0; vertical < mapLength; vertical++)
            {
                for (int horizon = 0; horizon < mapWidth; horizon++)
                {
                    field[vertical, horizon] = "，";
                    if (horizon == 1 && vertical == (mapLength - 1) / 2)
                    {
                        field[vertical, horizon] = "ⓟ";

                        playerPosX = horizon;
                        playerPosY = vertical;
                    }
                    //else if (horizon == (mapWidth - 1) && vertical == (mapLength - 1) / 2)  // 동
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    else if (horizon == 0 && vertical == (mapLength - 1) / 2)  // 서
                    {
                        field[vertical, horizon] = "♨";
                    }
                    //else if (horizon == (mapWidth - 1) / 2 && vertical == (mapLength-1))  // 남
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == (mapWidth - 1) / 2 && vertical == 0)  // 북
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                }
            }

            DrawMap();

        }




        public void MakeMapRight_Move()
        {
            while (true)
            {
                #region 조작관련 부분
                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:

                        if (playerPosY > 0)
                        {
                            playerPosY -= 1;
                            if (field[playerPosY, playerPosX] == "♨")
                            {

                            }
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                        }
                        else if (playerPosY == 0)
                        {
                            playerPosY = 0;
                        }
                        break;


                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:

                        if (playerPosY < (mapLength - 1))
                        {
                            playerPosY += 1;
                            if (field[playerPosY, playerPosX] == "♨")
                            {

                            }
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                        }
                        else if (playerPosY == (mapLength - 1))
                        {
                            playerPosY = (mapLength - 1);
                        }
                        break;


                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:

                        if (playerPosX > 0)
                        {
                            playerPosX -= 1;
                            if (field[playerPosY, playerPosX] == "♨")
                            {

                            }
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                        }
                        else if (playerPosX == 0)
                        {
                            playerPosX = 0;
                        }
                        break;


                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:

                        if (playerPosX < (mapWidth - 1))
                        {
                            playerPosX += 1;
                            if (field[playerPosY, playerPosX] == "♨")
                            {

                            }
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                            //else if () 
                            //{

                            //}
                        }
                        else if (playerPosX == (mapWidth - 1))
                        {
                            playerPosX = (mapWidth - 1);
                        }
                        break;
                }
                #endregion

                Console.Clear();

                #region 바뀐 좌표 정의
                for (int vertical = 0; vertical < mapLength; vertical++)
                {
                    for (int horizon = 0; horizon < mapWidth; horizon++)
                    {
                        field[vertical, horizon] = "，";
                        if (horizon == playerPosX && vertical == playerPosY)
                        {
                            field[vertical, horizon] = "ⓟ";
                        }
                        else if (horizon == 0 && vertical == (mapLength - 1) / 2)
                        {
                            field[vertical, horizon] = "♨";
                        }
                    }
                }
                #endregion

                DrawMap();
            }

        }

        public void DrawMap()
        {
            for (int j = 0; j < mapLength; j++)
            {
                for (int i = 0; i < mapWidth; i++)
                {
                    Console.Write("{0}", field[j, i]);
                }
                Console.WriteLine();
            }
        }

    }
}
