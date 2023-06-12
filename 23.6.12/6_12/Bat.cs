using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_12
{
    public class Bat
    {
        private string Name = "쥬벳";
        private string Type = "박쥐";
        private int HP = 10;
        private int MP = 10;
        private int DMG = 20;
        private int DEF = 10;

        public void Print_Bat_Desc() 
        {
            Console.Write("이 몬스터의 이름은 {0}이며, 몬스터타입은 {1} 이다.", Name, Type);
            Console.WriteLine();
            Console.Write("HP : {0}, MP : {1}, DMG : {2}, DEF : {3}", HP, MP, DMG, DEF);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
