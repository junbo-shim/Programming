using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_14_1
{
    public class Item_info
    {
        public string item_name;
        public int item_count;
        public int item_price;
        //public int item_number;


        public void Initialize(string name, int count, int price) 
        {
            item_name = name;
            item_count = count;
            item_price = price;
            //item_number = number;
        }

    }

 



}
