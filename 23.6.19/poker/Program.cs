using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card_Pool card_Pool001 = new Card_Pool();
            card_Pool001.Make_Card_Pool();
            card_Pool001.Print_Cards();
            card_Pool001.Change_Card();


        }
    }
}
