using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            game GGame = new game();
            GGame.Make_Field();
            GGame.Move_One();
        }
    }
}
