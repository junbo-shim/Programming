using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _6_14_1
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // 아이템인포 클래스 정의
            Item_info short_sword = new Item_info();
            Item_info long_sword = new Item_info();
            Item_info buckler = new Item_info();
            Item_info steeleto = new Item_info();
            Item_info rusted_helmet = new Item_info();
            Item_info rusted_armor = new Item_info();
            Item_info rusted_shield = new Item_info();
            Item_info rusted_great_sword = new Item_info();


            // 아이템 초기화 (만들 갯수만큼)
            short_sword.Initialize("숏소드", 1, 200);
            long_sword.Initialize("롱소드", 1, 450);
            buckler.Initialize("버클러", 1, 100);
            steeleto.Initialize("스틸레토", 1, 150);
            rusted_helmet.Initialize("낡은 헬멧", 1, 50);
            rusted_armor.Initialize("녹슨 갑옷", 1, 80);
            rusted_shield.Initialize("낡은 방패", 1, 80);
            rusted_great_sword.Initialize("녹슨 대검", 1, 240);


            // 아이템 클래스를 이용하여 리스트(아이템풀) 하나 만들기
            Dictionary<string, Item_info> Item_Pool = new Dictionary<string, Item_info>();
            Item_Pool.Add("숏소드", short_sword);
            Item_Pool.Add("롱소드", long_sword);
            Item_Pool.Add("버클러", buckler);
            Item_Pool.Add("스틸레토", steeleto);
            Item_Pool.Add("낡은 헬멧", rusted_helmet);
            Item_Pool.Add("녹슨 갑옷", rusted_armor);
            Item_Pool.Add("낡은 방패", rusted_shield);
            Item_Pool.Add("녹슨 대검", rusted_great_sword);

            Console.WriteLine("아이템 리스트");
            foreach (var item in Item_Pool)
            {
                Console.WriteLine("아이템 고유넘버: {0}, 아이템 이름: {1}, 아이템 갯수: {2}, 아이템 가격: {3}",
                    item.Key, item.Value.item_name, item.Value.item_count, item.Value.item_price);
            }

            Random random = new Random();
            int random_number_1 = random.Next(1, 9);
            int random_number_2 = random.Next(1, 9);
            int random_number_3 = random.Next(1, 9);

            // 3갈래로 찢기
            List<string> Shop_List_Name = new List<string>(Item_Pool.Keys);
            Shop_List_Number.Add(random_number_1);
            Shop_List_Number.Add(random_number_2);
            Shop_List_Number.Add(random_number_3);

            //List<Item_info> tempList = Item_Pool.Values.ToList();
            foreach (Item_info valueOne in Item_Pool.Values)
            {
                Shop_List_Info.Add(valueOne.item_count);
                Shop_List_Info.Add(valueOne.item_price);
            }
            List<int> Shop_List_Count = new List<int>(Item_Pool.Values);
            Shop_List_Info.Add(Item_Pool);
            Shop_List_Info.Add(Item_Pool);
            Shop_List_Info.Add(Item_Pool);

            List<int> Shop_List_Count = new List<int>(Item_Pool.Values);
            Shop_List_Info.Add(Item_Pool);
            Shop_List_Info.Add(Item_Pool);
            Shop_List_Info.Add(Item_Pool);




            Console.WriteLine("상점 테스트");
            foreach (var item in Shop_List_Number)
            {
                Console.WriteLine("{0}", item);
            }


            var myTable = new Dictionary<string, string>();
            myTable.Add("Korea", "Seoul";);
            myTable.Add("Japan", "Tokyo";);
            myTable.Add("America", "Washington";);

            var kList = new List<string>(myTable.Keys);
            var vList = new List<string>(myTable.Values);



            // 리스트에 아이템을 8개 넣기 (아이템 이름, 아이템 갯수, 아이템 가격, 아이템 고유넘버)

            // 상점용 리스트 만들기
            // 랜덤값을 적용하여 아이템 고유넘버를 뽑기
            // 리스트에 아이템 고유넘버를 넣어 불러오기?


            // 아이템 
            // 유저 인벤토리용 가변배열을 생성하여 




            //string[,] Shop_Iven_Cursor = new string[3, 2];
            //int shop_x = default;
            //int shop_y = default;



            //    for (int y = 0; y < 4; y++)
            //    {
            //        for (int x = 0; x < 2; x++)
            //        {
            //            Shop_Iven_Cursor[y, x] = "                  ";

            //            if (y == 0 && x == 0)
            //            {
            //                Shop_Iven_Cursor[y, x] = "☞                ";
            //                shop_x = x;
            //                shop_y = y;

            //            }

            //        }


            //    }

            //    Console.Clear();
            //    // 이중 for문으로 이차원 배열 출력
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int i = 0; i < 2; i++)
            //        {
            //            // 출력할 배열 좌표
            //            Console.Write("{0}", Shop_Iven_Cursor[j, i]);
            //        }
            //        //한줄 띄우기
            //        Console.WriteLine();
            //    }



















        }
    }
}
