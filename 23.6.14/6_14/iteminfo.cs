using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_14
{
    public class item_info
    {
        public string item_Name;
        public int item_Count;
        public int item_Price;


   

    public void Initialize(string name, int count, int price) 
    {
        item_Name = name;
        item_Count = count;
        item_Price = price;

    }
 }
}
