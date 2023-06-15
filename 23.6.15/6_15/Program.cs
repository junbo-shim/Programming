using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            enumdesc.ItemType_ = new 

            // 내가 정의한 enum 타입 변수를 선언해 볼 것임
            ItemType_ itemType;

            itemType = ItemType_.POSTION;
            Console.WriteLine("enum 타입은 무엇이라고 출력될까? -> {0}", itemType);

            switch (itemType) 
            {
                case ItemType_.POSTION:
                    Console.WriteLine("이 아이템은 포션");
                    break;
                case ItemType_.GOLD:
                    Console.WriteLine("이 아이템은 골드");
                    break;
                case ItemType_.WEAPON:
                    Console.WriteLine("이 아이템은 무기");
                    break;
                case ItemType_.ARMOR:
                    Console.WriteLine("이 아이템은 갑옷");
                    break;

            }
                

        }
    }
}
