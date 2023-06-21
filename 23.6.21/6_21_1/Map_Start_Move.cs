using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21_1
{
    internal partial class Map_Start
    {
 


        // 플레이어 이동 시의 좌표 변화 및 출력부
        #region 이동 좌표 변화 및 출력
        public void MakeMapStart_Move()
        {

            for (int i = 0; i < LevelRandomWall; i++)   // 랜덤 좌표 난이도 횟수만큼 배열로 저장
            {
                randomX[i] = random.Next(2, (MapWidth - 2));
                randomY[i] = random.Next(2, (MapLength - 2));
            }


            while (true)
            {
                #region 조작관련 부분
                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:

                        if (playerPosY > 1 && field[(playerPosY - 1), playerPosX] != "▣")   // playerPosY - 1 = 플레이어 위쪽
                        {                                                                    // 위쪽에 장애물이 없을 경우
                            playerPosY -= 1;
                        }
                        else if (playerPosY == 1)
                        {
                            playerPosY = 1;
                        }
                        playerMoveCount++;  // 플레이어 이동 카운트 증가
                        break;


                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:

                        if (playerPosY < (MapLength - 2) && field[(playerPosY + 1), playerPosX] != "▣")     // playerPosY + 1 = 플레이어 아래쪽
                        {                                                                                    // 아래쪽에 장애물이 없을 경우
                            playerPosY += 1;
                        }
                        else if (playerPosY == (MapLength - 2))
                        {
                            playerPosY = (MapLength - 2);
                        }
                        playerMoveCount++;
                        break;


                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:

                        if (playerPosX > 1 && field[playerPosY, (playerPosX - 1)] != "▣")  // playerPosX - 1 = 플레이어 왼쪽
                        {                                                                   // 왼쪽에 장애물이 없을 경우
                            playerPosX -= 1;
                        }
                        else if (playerPosX == 1)
                        {
                            playerPosX = 1;
                        }
                        playerMoveCount++;
                        break;


                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:

                        if (playerPosX < (MapWidth - 2) && field[playerPosY, (playerPosX + 1)] != "▣")  // playerPosX + 1 = 플레이어 오른쪽
                        {                                                                                // 오른쪽에 장애물이 없을 경우
                            playerPosX += 1;
                        }
                        else if (playerPosX == (MapWidth - 2))
                        {
                            playerPosX = (MapWidth - 2);
                        }
                        playerMoveCount++;
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




                // 장애물 좌표 생성
                #region 장애물 좌표 생성부
                for (int i = 0; i < LevelRandomWall; i++)       // 난이도 횟수만큼 for문 돌림
                {
                    if (field[randomY[i], randomX[i]] != "■" && field[randomY[i], randomX[i]] != "▣"
                        && field[randomY[i], randomX[i]] != "●")    // 벽이 아니고, 장애물도 아니며, 플레이어도 아닐 경우 장애물 생성
                    {
                        field[randomY[i], randomX[i]] = "▣";
                    }
                }
                #endregion
                // 장애물 좌표 생성끝





                while(enemyCount < 4) 
                {
                    CreateEnemy();
                }










                DrawMap();
            }

        }
        #endregion
        // 플레이어 이동 시의 좌표 변화 및 출력부 끝

    }
}
