using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public partial class Map
    {



        public void DrawMap()   // 맵을 그릴 함수
        {
            for(int j = 0; j < MapLength; j++) 
            {
                for(int i = 0; i < MapWidth; i++) 
                {
                    if (field[j, i] == "□") 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("{0}", field[j, i]);
                        Console.ResetColor();
                    }
                    else if (field[j, i] == "，") 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("{0}", field[j, i]);
                        Console.ResetColor();
                    }
                    else if (field[j, i] == "⊙") 
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{0}", field[j, i]);
                        Console.ResetColor();
                    }
                    else if (field[j, i] == "◎") 
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("{0}", field[j, i]);
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }
            PrintUI();


        }



    }
}
