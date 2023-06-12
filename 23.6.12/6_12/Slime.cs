using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_12
{
    public class Slime
    {
        private string slimeName = "파랑이";
        private string slimeType = "슬라임";
        private int HP = 40;
        private int MP = 3;
        private int DMG = 5;
        private int DEF = 2;

        public void Print_Slime_Desc() 
        {
            Console.Write("이 몬스터의 이름은 {0}이며, 몬스터타입은 {1} 이다.", slimeName, slimeType);
            Console.WriteLine();
            Console.Write("HP : {0}, MP : {1}, DMG : {2}, DEF : {3}", HP, MP, DMG, DEF);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
