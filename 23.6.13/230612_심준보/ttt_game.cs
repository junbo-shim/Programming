using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttt
{
    public class ttt_game
    {
        int[,] game_table = new int[3, 3];


        public void Put_Stone()
        {

            int user_number = default;
            


            Console.Write("7 │ 8 │ 9");
            Console.WriteLine();
            Console.Write("──────────");
            Console.WriteLine();
            Console.Write("4 │ 5 │ 6");
            Console.WriteLine();
            Console.Write("──────────");
            Console.WriteLine();
            Console.Write("1 │ 2 │ 3");
            Console.WriteLine();
            Console.Write("1~9 까지의 숫자를 누르세요");
            Console.WriteLine();

            

            

            int.TryParse(Console.ReadLine(), out user_number);

           
                switch (user_number)
                {
                    case 1:
                        game_table[2, 0] = 1;
                        Console.Clear();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────"); ;
                        Console.WriteLine();
                        Console.Write("1 │ 0 │ 0");
                        break;
                    case 2:
                        game_table[2, 1] = 1;
                        Console.Clear();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 1 │ 0");
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 1");
                        break;
                    case 4:
                        game_table[1, 0] = 1;
                        Console.Clear();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("1 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        break;
                    case 5:
                        game_table[1, 1] = 1;
                        Console.Clear();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 1 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        break;
                    case 6:
                        game_table[1, 2] = 1;
                        Console.Clear();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 1");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        break;
                    case 7:
                        game_table[0, 0] = 1;
                        Console.Clear();
                        Console.Write("1 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        break;
                    case 8:
                        game_table[0, 1] = 1;
                        Console.Clear();
                        Console.Write("0 │ 1 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        break;
                    case 9:
                        game_table[0, 2] = 1;
                        Console.Clear();
                        Console.Write("0 │ 0 │ 1");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        Console.WriteLine();
                    Console.Write("──────────");
                    Console.WriteLine();
                        Console.Write("0 │ 0 │ 0");
                        break;
                    default:
                        Console.WriteLine();
                        Console.Write("유효하지 않은 입력입니다.");
                        break;
                

                }
        }

            public void Make_Array() 
        {
            for (int y = 0; y<=2; y++) 
            {
                for(int x = 0; x<=2; x++) 
                {
                    Console.Write("{0}  ", game_table[y, x]);
                }
                Console.WriteLine();
            }
        }







    }
}
