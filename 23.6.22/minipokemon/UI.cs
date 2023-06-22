using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public partial class Map
    {



        public void PrintUI() 
        {
            Console.SetCursorPosition(64, 0);
            Console.Write("당신의 현재 로스터 : \n");
            Console.SetCursorPosition(85, 2);
            Console.Write("{0}/{1}  {2}/{3}\n");
            Console.SetCursorPosition(64, 4);
            Console.Write("당신의 현재 퀘스트 : \n");


        }


    }
}
