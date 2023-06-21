using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21_1
{
    internal class Map_Start2
    {
        // 상수 값 설정 (맵 가로 세로, 난이도 레벨)
        const int MapWidth = 20;
        const int MapLength = 15;
        const int LevelRandomWall = 3;

        // 유저 인풋, xy좌표 저장 변수 선언 
        string userInput = default;
        int playerPosX = default;
        int playerPosY = default;
        Random random = new Random();

        // 맵(2차원배열), 랜덤xy좌표 저장용 배열 선언
        string[,] field = new string[MapLength, MapWidth];
        int[] randomX = new int[LevelRandomWall];
        int[] randomY = new int[LevelRandomWall];

        
        // 실행부 전방으로 뺌
        public void DoMapStart()
        {
            Console.Clear();

            MakeMapStart_First();
            MakeMapStart_Move();
        }




        // 맵의 초기 상태 정의 및 출력부
        #region 초기 맵 정의 및 출력
        public void MakeMapStart_First()
        {

            for (int i = 0; i < LevelRandomWall; i++)
            {
                randomX[i] = random.Next(2, (MapWidth - 2));
                randomY[i] = random.Next(2, (MapLength - 2));
            }


            for (int vertical = 0; vertical < MapLength; vertical++)
            {
                for (int horizon = 0; horizon < MapWidth; horizon++)
                {
                    field[vertical, horizon] = "□"; // 길
                    if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1) / 2)
                    {
                        field[vertical, horizon] = "●"; // 플레이어

                        playerPosX = horizon;
                        playerPosY = vertical;
                    }
                    else if (vertical == 0)
                    {
                        field[vertical, horizon] = "■"; // 위쪽 벽
                    }
                    else if (vertical == (MapLength - 1))
                    {
                        field[vertical, horizon] = "■"; // 아래쪽 벽
                    }
                    else if (horizon == 0)
                    {
                        field[vertical, horizon] = "■"; // 좌측 벽
                    }
                    else if (horizon == (MapWidth - 1))
                    {
                        field[vertical, horizon] = "■"; // 우측 벽
                    }
                    else if () 
                    { }






                    #region 포탈
                    //else if (horizon == (MapWidth - 1) && vertical == (MapLength - 1) / 2)  // 동
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == 0 && vertical == (MapLength - 1) / 2)  // 서
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1))  // 남
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == (MapWidth - 1) / 2 && vertical == 0)  // 북
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    #endregion
                }
            }






            DrawMap();

        }
        #endregion
        // 맵의 초기 상태 정의 및 출력부 끝


        // 플레이어 이동 시의 좌표 변화 및 출력부
        #region 이동 좌표 변화 및 출력
        public void MakeMapStart_Move()
        {
            while (true)
            {
                #region 조작관련 부분
                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:

                        if (playerPosY > 1)
                        {
                            playerPosY -= 1;
                            if (playerPosX == (MapWidth - 1) && playerPosY == (MapLength - 1) / 2)
                            {
                                //DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (MapLength - 1) / 2)
                            {
                                //DoMapLeft();
                            }
                            else if (playerPosX == (MapWidth - 1) / 2 && playerPosY == 0)
                            {
                                //DoMapUp();
                            }
                        }
                        else if (playerPosY == 1)
                        {
                            playerPosY = 1;
                        }
                        break;


                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:

                        if (playerPosY < (MapLength - 2))
                        {
                            playerPosY += 1;
                            if (playerPosX == (MapWidth - 1) && playerPosY == (MapLength - 1) / 2)
                            {
                                //DoMapRight();
                            }
                            else if (playerPosX == 0 && playerPosY == (MapLength - 1) / 2)
                            {
                                //DoMapLeft();
                            }
                            else if (playerPosX == (MapWidth - 1) / 2 && playerPosY == (MapLength - 1))
                            {
                                //DoMapDown();
                            }
                        }
                        else if (playerPosY == (MapLength - 2))
                        {
                            playerPosY = (MapLength - 2);
                        }
                        break;


                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:

                        if (playerPosX > 1)
                        {
                            playerPosX -= 1;
                            if (playerPosX == 0 && playerPosY == (MapLength - 1) / 2)
                            {
                                //DoMapLeft();
                            }
                            else if (playerPosX == (MapWidth - 1) / 2 && playerPosY == (MapLength - 1))
                            {
                                //DoMapDown();
                            }
                            else if (playerPosX == (MapWidth - 1) / 2 && playerPosY == 0)
                            {
                                //DoMapUp();
                            }
                        }
                        else if (playerPosX == 1)
                        {
                            playerPosX = 1;
                        }
                        break;


                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:

                        if (playerPosX < (MapWidth - 2))
                        {
                            playerPosX += 1;
                            if (playerPosX == (MapWidth - 1) && playerPosY == (MapLength - 1) / 2)
                            {
                                //DoMapRight();
                            }
                            else if (playerPosX == (MapWidth - 1) / 2 && playerPosY == (MapLength - 1))
                            {
                                //DoMapDown();
                            }
                            else if (playerPosX == (MapWidth - 1) / 2 && playerPosY == 0)
                            {
                                //DoMapUp();
                            }
                        }
                        else if (playerPosX == (MapWidth - 2))
                        {
                            playerPosX = (MapWidth - 2);
                        }
                        break;
                }
                #endregion

                Console.SetCursorPosition(0, 0);


                #region 변화좌표 정의
                for (int vertical = 0; vertical < MapLength; vertical++)
                {
                    for (int horizon = 0; horizon < MapWidth; horizon++)
                    {
                        field[vertical, horizon] = "□";
                        if (horizon == playerPosX && vertical == playerPosY)
                        {
                            field[vertical, horizon] = "●";
                        }
                        else if (vertical == 0)
                        {
                            field[vertical, horizon] = "■";
                        }
                        else if (vertical == (MapLength - 1))
                        {
                            field[vertical, horizon] = "■";
                        }
                        else if (horizon == 0)
                        {
                            field[vertical, horizon] = "■";
                        }
                        else if (horizon == (MapWidth - 1))
                        {
                            field[vertical, horizon] = "■";
                        }

                        for (int i = 0; i < LevelRandomWall; i++)
                        {
                            randomX[i] = random.Next(2, (MapWidth - 2));
                            randomY[i] = random.Next(2, (MapLength - 2));
                            field[randomY[i], randomX[i]] = "▣";
                        }





                        #region 포탈
                        //else if (horizon == (MapWidth - 1) && vertical == (MapLength - 1) / 2)  // 동
                        //{
                        //    field[vertical, horizon] = "♨";
                        //}
                        //else if (horizon == 0 && vertical == (MapLength - 1) / 2)  // 서
                        //{
                        //    field[vertical, horizon] = "♨";
                        //}
                        //else if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1))  // 남
                        //{
                        //    field[vertical, horizon] = "♨";
                        //}
                        //else if (horizon == (MapWidth - 1) / 2 && vertical == 0)  // 북
                        //{
                        //    field[vertical, horizon] = "♨";
                        //}
                        #endregion
                    }
                }
                #endregion

                DrawMap();
            }

        }
        #endregion
        // 플레이어 이동 시의 좌표 변화 및 출력부 끝



        // 맵 출력부
        #region 맵 출력 메서드
        public void DrawMap()
        {
            for (int j = 0; j < MapLength; j++)
            {
                for (int i = 0; i < MapWidth; i++)
                {
                    Console.Write("{0}", field[j, i]);
                }
                Console.WriteLine();
            }
        }
        #endregion
        // 맵 출력부 끝

    }
}
