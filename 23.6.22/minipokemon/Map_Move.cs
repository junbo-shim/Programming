using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public partial class Map
    {
        public void MoveInMap()     // 맵 초기화 및 출력 함수
        {


            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                switch (userInput.Key) 
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:

                        if (playerY  > 0) 
                        {
                            if (field[(playerY - 1), playerX] == "◎")
                            {

                                if (receivedQuestCount == 0 && doneQuestCount == 0)
                                {
                                    playerY += 1;
                                    TalkToNPC();
                                    
                                }
                                else if (receivedQuestCount == 1 && doneQuestCount == 0)
                                {
                                    playerY += 1;
                                    TalkToNPC2();

                                }
                                else if (receivedQuestCount == 0 && doneQuestCount == 1)
                                {
                                    playerY += 1;
                                    TalkToNPC3();

                                }
                            }
                            else
                            {
                                playerY -= 1;
                            }
                        }
                        else if (playerY == 0) 
                        {
                            playerY = 0;
                        }


                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:

                        if (playerY < (MapLength - 1))
                        {
                            if (field[(playerY + 1), playerX] == "◎")
                            {
                                if (receivedQuestCount == 0 && doneQuestCount == 0)
                                {
                                    playerY -= 1;
                                    TalkToNPC();

                                }
                                else if (receivedQuestCount == 1 && doneQuestCount == 0)
                                {
                                    playerY -= 1;
                                    TalkToNPC2();
                                }
                                else if (receivedQuestCount == 0 && doneQuestCount == 1)
                                {
                                    playerY -= 1;
                                    TalkToNPC3();
                                }
                            }
                        }
                        else if (playerY == (MapLength - 1))
                        {
                            playerY = (MapLength - 1);
                        }


                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:

                        if (playerX < (MapWidth - 1))
                        {
                            if (field[playerY, (playerX + 1)] == "◎")
                            {
                                if (receivedQuestCount == 0 && doneQuestCount == 0)
                                {
                                    playerX += 1;
                                    TalkToNPC();

                                }
                                else if (receivedQuestCount == 1 && doneQuestCount == 0)
                                {
                                    playerX += 1;
                                    TalkToNPC2();
                                }
                                else if (receivedQuestCount == 0 && doneQuestCount == 1)
                                {
                                    playerX += 1;
                                    TalkToNPC3();
                                }
                            }
                        }
                        else if (playerX == (MapWidth - 1))
                        {
                            playerX = (MapWidth - 1);
                        }


                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:

                        if (playerX > 0 && field[playerY, playerX] != "◎")
                        {
                            if (field[playerY, (playerX - 1)] == "◎")
                            {
                                if (receivedQuestCount == 0 && doneQuestCount == 0)
                                {
                                    playerX -= 1;
                                    TalkToNPC();

                                }
                                else if (receivedQuestCount == 1 && doneQuestCount == 0)
                                {
                                    playerX -= 1;
                                    TalkToNPC2();
                                }
                                else if (receivedQuestCount == 0 && doneQuestCount == 1)
                                {
                                    playerX -= 1;
                                    TalkToNPC3();
                                }
                            }
                        }
                        else if (playerX == 0)
                        {
                            playerX = 0;
                        }


                        break;
                }


                Console.SetCursorPosition(0, 0);


                for (int vertical = 0; vertical < MapLength; vertical++)
                {
                    for (int horizon = 0; horizon < MapWidth; horizon++)
                    {
                        field[vertical, horizon] = "□";     // 기본적 타일
                    }
                }

                for (int j = 0; j < (MapLength - 1) / 3; j++)
                {
                    for (int i = 2 * (MapWidth - 1) / 3; i < (MapWidth - 1); i++)
                    {

                        field[j, i] = "，";

                    }
                }

                for (int vertical = 0; vertical < MapLength; vertical++)
                {
                    for (int horizon = 0; horizon < MapWidth; horizon++)
                    {
                        if (horizon == playerX && vertical == playerY)   // 플레이어의 초기 위치 = 맵 중앙
                        {
                            field[playerY, playerX] = "⊙";     // 플레이어 아이콘
                        }
                        else if (horizon == npcX && vertical == npcY)
                        {
                            field[vertical, horizon] = "◎";

                        }
                    }
                }

                DrawMap();      // 맵을 그릴 함수

            }
        }


    }
}
