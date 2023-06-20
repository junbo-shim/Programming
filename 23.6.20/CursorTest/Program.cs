using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(1, 5);
            Console.WriteLine("Hell로");
            Console.SetCursorPosition(1, 5);
            Console.WriteLine("s");

        }
    }
}
