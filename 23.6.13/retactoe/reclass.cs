using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace retactoe
{
    public class reClass
    {
        string[,] game_table = new string[3, 3] { { "　", "　", "　" }, { "　", "　", "　" }, { "　", "　", "　" } };





        public void Put_Stone()
        {
            string user_stone = "O";

            while (true)
            {
                int.TryParse(Console.ReadLine(), out int user_number);

                if (user_number >= 1 && user_number <= 9)
                {
                    int x = (user_number - 1) % 3;
                    int y = (user_number - 1) / 3;


                    Console.Write("림보 111");
                    while (true)//whule문의 위치가 이상하다
                    {
                        Console.Write("림보");
                        Task.Delay(1000).Wait();
                        if (game_table[y, x] == "　")
                        {
                            Console.Write("!!!!!!!!!!!!!!!");
                            game_table[y, x] = user_stone;
                            break;
                        }
                        else
                        {
                            Console.Write("해당 위치에 놓을 수 없습니다.");
                            break;
                        }
                    }
                    Console.Write("??????????");
                    break;
                }
                else
                {
                    Console.Write("좌표를 다시 입력하세요.  (1~9)");
                }

                Console.Write("림보 222");
            }
        }


        public void Put_Stone2()
        {
            string user_stone = "O";
            int.TryParse(Console.ReadLine(), out int user_number);
            int x = (user_number - 1) % 3;
            int y = (user_number - 1) / 3;


            if (game_table[y, x] == "　")
            {
                game_table[y, x] = user_stone;
                
            }
            else
            {
                Console.Write("해당 위치에 놓을 수 없습니다.");
            }

            if (game_table[y, x] == "　")
            {
                game_table[y, x] = user_stone;

            }
            else
            {
                Console.Write("해당 위치에 놓을 수 없습니다.");
            }

            if (game_table[y, x] == "　")
            {
                game_table[y, x] = user_stone;

            }
            else
            {
                Console.Write("해당 위치에 놓을 수 없습니다.");
            }
        }











        public void Com_Stone()
        {
            Random random = new Random();
            string com_stone = "X";

            int com_x = (random.Next(0, 3));
            int com_y = (random.Next(0, 3));


            while (true)
            {
                if (game_table[com_y, com_x] == "　")
                {
                    game_table[com_y, com_x] = com_stone;
                    break;
                }
                else if (game_table[com_y, com_x] != "　")
                {
                    //3번째
                    Console.Write("여기");
                    continue;
                }

                Console.Write("ㅁㅈㄱ");
            }
        }



        public void Win_Check()
        {
            while (true)
            {
                if (game_table[0, 0] == game_table[1, 0] && game_table[1, 0] == game_table[2, 0]) // 세로
                {
                    if (game_table[0, 0] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if (game_table[0, 0] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[0, 1] == game_table[1, 1] && game_table[1, 1] == game_table[2, 1])
                {
                    if (game_table[0, 1] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if (game_table[0, 1] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[0, 2] == game_table[1, 2] && game_table[1, 2] == game_table[2, 2])
                {
                    if (game_table[0, 2] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if(game_table[0, 2] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[0, 0] == game_table[0, 1] && game_table[0, 1] == game_table[0, 2]) // 가로
                {
                    if (game_table[0, 0] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if(game_table[0, 0] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[1, 0] == game_table[1, 1] && game_table[1, 1] == game_table[1, 2])
                {
                    if (game_table[1, 0] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if(game_table[1, 0] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[2, 0] == game_table[2, 1] && game_table[2, 1] == game_table[2, 2])
                {
                    if (game_table[2, 0] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if(game_table[2, 0] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[0, 0] == game_table[1, 1] && game_table[1, 1] == game_table[2, 2]) // 대각선
                {
                    if (game_table[0, 0] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if (game_table[0, 0] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else if (game_table[0, 2] == game_table[1, 1] && game_table[1, 1] == game_table[2, 0])
                {
                    if (game_table[0, 2] == "O")
                    {
                        Console.Write("TIC TAC TOE! 당신이 승리했습니다!");
                    }
                    else if (game_table[0, 2] == "X")
                    {
                        Console.Write("당신은 패배했습니다...");
                    }
                    break;
                }
                else
                {
                    //여기하나더
                    Console.Write("@:|:|@");
                    continue;
                }
            }
        }



        public void Table_Out()
        {

            Console.Clear();
            Console.Write("{0} | {1} | {2}          1 │ 2 │ 3", game_table[0, 0], game_table[0, 1], game_table[0, 2]);
            Console.WriteLine();
            Console.Write("──────────        ──────────");
            Console.WriteLine();
            Console.Write("{0} | {1} | {2}          4 │ 5 │ 6", game_table[1, 0], game_table[1, 1], game_table[1, 2]);
            Console.WriteLine();
            Console.Write("──────────        ──────────");
            Console.WriteLine();
            Console.Write("{0} | {1} | {2}          7 │ 8 │ 9", game_table[2, 0], game_table[2, 1], game_table[2, 2]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("1~9 까지의 숫자를 누르세요");
            Console.WriteLine();

        }



        public void GGame() 
        {
            while (true) 
            {
                Put_Stone();
                Console.Write("@@@@@@@@@@@@");

                Com_Stone();
                Console.Write("@@))))))))))@@@");
                Win_Check();
                Console.Write("@@@((((((((((");
                Table_Out();
                Console.Write("@@@@^^^^^^^^^^@@@");
            }
        }


    }
}


