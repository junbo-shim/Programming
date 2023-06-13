using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_13
{
    public class Game
    {
        int user_x;
        int user_y;
        string[,] field = new string[5, 5];



        public void Field_()
        {

            //int user_input = 0;

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    field[j, i] = "* ";

                    if (j == 2 && i == 2)
                    {
                        field[j, i] = "0 ";
                        user_x = i;
                        user_y = j;

                    }
                }

            }


            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0}", field[j, i]);
                }
                Console.WriteLine();
            }

        }




        public void Swap(ref string first, ref string second)                   // 셔플 함수
        {
            string temp = default;
            temp = first;
            first = second;
            second = temp;
        }



        public void Move() 
        {

            while (true) 
            {
                ConsoleKeyInfo user_input = Console.ReadKey();
                if (user_input.Key == ConsoleKey.UpArrow)
                {
                    user_y -= 1;

                }
                else if (user_input.Key == ConsoleKey.DownArrow)
                {
                    user_y += 1;

                }
                else if (user_input.Key == ConsoleKey.LeftArrow)
                {
                    user_x -= 1;

                }
                else if (user_input.Key == ConsoleKey.RightArrow)
                {
                    user_x += 1;

                }


                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        field[j, i] = "* ";

                        if (j == user_y && i == user_x)
                        {
                            field[j, i] = "0 ";

                        }
                    }

                }


                Console.Clear();
                for (int j = 0; j < 5; j++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("{0}", field[j, i]);
                    }
                    Console.WriteLine();
                }
            }

        }

    }

}








