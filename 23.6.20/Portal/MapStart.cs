using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Portal
{
    public class MapStart
    {


        const int mapWidth = 20;
        const int mapLength = 15;
        string[,] field = new string[mapLength, mapWidth];


        string userInput = default;
        int playerPosX = default;
        int playerPosY = default;






        public void DoMap() 
        {
            MakeMap_First();
            MakeMap_Move();
        }

        public void DoMapRight() 
        {
            Console.Clear();
            ComeFromRightPortal_First();
            ComeFromRightPortal_Move();
        }


        public void DoMapLeft() 
        {
            Console.Clear();
            ComeFromLeftPortal_First();
            ComeFromLeftPortal_Move();    
        }

        //public void DoMapUp()
        //{
        //    Console.Clear();
        //    ComeFromUpPortal_First();
        //    ComeFromUpPortal_Move();
        //}


        //public void DoMapDown()
        //{
        //    Console.Clear();
        //    ComeFromDownPortal_First();
        //    ComeFromDownPortal_Move();
        //}







        #region 초기 맵 정의 및 출력
        public void MakeMap_First() 
        {
            for(int vertical = 0; vertical < mapLength; vertical++)
            {
                for(int horizon = 0; horizon < mapWidth; horizon++) 
                {
                    field[vertical, horizon] = "，";
                    if(horizon == (mapWidth - 1) / 2 && vertical == (mapLength - 1) / 2) 
                    {
                        field[vertical, horizon] = "ⓟ";

                        playerPosX = horizon;
                        playerPosY = vertical;
                    }
                    else if (horizon == (mapWidth - 1) && vertical == (mapLength - 1) / 2)  // 동
                    {
                        field[vertical, horizon] = "♨";
                    }
                    else if (horizon == 0 && vertical == (mapLength - 1) / 2)  // 서
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                    else if (horizon == (mapWidth - 1) / 2 && vertical == (mapLength - 1))  // 남
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                    else if (horizon == (mapWidth - 1) / 2 && vertical == 0)  // 북
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                }
            }

            DrawMap();

        }
        #endregion


        #region 이동 좌표 변화 및 출력
        public void MakeMap_Move() 
        {
            while (true) 
            {
                #region 조작관련 부분
                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key) 
                {
                    case ConsoleKey.UpArrow :
                    case ConsoleKey.W :

                        if (playerPosY > 0) 
                        {
                            playerPosY -= 1;
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2) 
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
                        }
                        else if (playerPosX == (mapWidth - 1))
                        {
                            playerPosX = (mapWidth - 1);
                        }
                        break;
                }
                #endregion

                Console.SetCursorPosition(0, 0);

                #region 바뀐 좌표 정의
                for (int vertical = 0; vertical < mapLength; vertical++) 
                {
                    for(int horizon = 0; horizon < mapWidth; horizon++) 
                    {
                        field[vertical, horizon] = "，";
                        if (horizon == playerPosX && vertical == playerPosY) 
                        {
                            field[vertical, horizon] = "ⓟ";
                        }
                        else if (horizon == (mapWidth - 1) && vertical == (mapLength - 1) / 2)
                        {
                            field[vertical, horizon] = "♨";
                        }
                    }
                }
                #endregion

                DrawMap();
            }

        }
        #endregion



        #region 맵 출력 메서드
        public void DrawMap() 
        {
            for(int j = 0; j < mapLength; j++) 
            {
                for (int i = 0; i < mapWidth; i++) 
                {
                    Console.Write("{0}", field[j, i]);
                }
                Console.WriteLine();
            }
        }
        #endregion


        #region 우측에서 올 때 초기 정의 및 출력
        public void ComeFromRightPortal_First() 
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
                    else if (horizon == 0 && vertical == (mapLength - 1) / 2)  // 동
                    {
                        field[vertical, horizon] = "♨";
                    }
                    else if (horizon == 0 && vertical == (mapLength - 1) / 2)  // 서
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                    else if (horizon == (mapWidth - 1) / 2 && vertical == (mapLength - 1))  // 남
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                    else if (horizon == (mapWidth - 1) / 2 && vertical == 0)  // 북
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                }
            }

            DrawMap();

        }
        #endregion



        public void ComeFromRightPortal_Move() 
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
                        }
                        else if (playerPosX == (mapWidth - 1))
                        {
                            playerPosX = (mapWidth - 1);
                        }
                        break;
                }
                #endregion

                Console.SetCursorPosition(0, 0);

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









        public void ComeFromLeftPortal_First() 
        {
            for (int vertical = 0; vertical < mapLength; vertical++)
            {
                for (int horizon = 0; horizon < mapWidth; horizon++)
                {
                    field[vertical, horizon] = "，";
                    if (horizon == (mapWidth - 2) && vertical == (mapLength - 1) / 2)
                    {
                        field[vertical, horizon] = "ⓟ";

                        playerPosX = horizon;
                        playerPosY = vertical;
                    }
                    else if (horizon == (mapWidth - 1) && vertical == (mapLength - 1) / 2)  // 동
                    {
                        field[vertical, horizon] = "♨";
                    }
                    else if (horizon == 0 && vertical == (mapLength - 1) / 2)  // 서
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                    else if (horizon == (mapWidth - 1) / 2 && vertical == (mapLength - 1))  // 남
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                    else if (horizon == (mapWidth - 1) / 2 && vertical == 0)  // 북
                    {
                        field[vertical, horizon] = "♨ ";
                    }
                }
            }

            DrawMap();

        }




        public void ComeFromLeftPortal_Move() 
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
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
                            if (playerPosX == (mapWidth - 1) && playerPosY == (mapLength - 1) / 2)
                            {
                                DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (mapLength - 1) / 2)
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == (mapLength - 1))
                            {

                            }
                            else if (playerPosX == (mapWidth - 1) / 2 && playerPosY == 0)
                            {

                            }
                        }
                        else if (playerPosX == (mapWidth - 1))
                        {
                            playerPosX = (mapWidth - 1);
                        }
                        break;
                }
                #endregion

                Console.SetCursorPosition(0, 0);

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
                        else if (horizon == (mapWidth - 1) && vertical == (mapLength - 1) / 2)
                        {
                            field[vertical, horizon] = "♨";
                        }
                    }
                }
                #endregion

                DrawMap();
            }

        }










    }
}
