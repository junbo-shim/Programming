using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_14_1
{
    public class ShopInven
    {

        string[,] Shop_Iven_Cursor = new string[3, 2];
        int shop_x = default;
        int shop_y = default;

        public void Shop_Inven_Grid() 
        {
            for(int y = 0; y < 4; y++) 
            {
                for(int x = 0; x < 2; x++)
                {
                    Shop_Iven_Cursor[y, x] = "                  ";

                    if(y==0 && x == 0) 
                    {
                        Shop_Iven_Cursor[y, x] = "☞                ";
                        shop_x = x;
                        shop_y = y;

                    }

                }


            }

            Console.Clear();
            // 이중 for문으로 이차원 배열 출력
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    // 출력할 배열 좌표
                    Console.Write("{0}", Shop_Iven_Cursor[j, i]);
                }
                //한줄 띄우기
                Console.WriteLine();
            }

        }



    }
}
