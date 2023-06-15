using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_15
{
    public class enumdesc

    {
        enum ItemType_          // enum은 상수타입 -> 상수(정수)에 네임태그를 다는 것
        {
            POTION, GOLD, WEAPON, ARMOR        // 0부터 시작하여 1, 2, 3 순차적으로 배정
            // POTION = 1, GOLD, WEAPON, ARMOR      // 1, 2, 3, 4 순서
            // POTION = 2, GOLD = 1, WEAPON, ARMOR=3        // 2, 1, 4, 3 순서 -> 다만 중복값은 불가능
        }


    }
}
