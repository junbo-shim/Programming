using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21_1
{
    internal partial class Map_Start
    {

        // 맵 출력부
        #region 맵 출력 메서드
        public void DrawMap()
        {
            for (int j = 0; j < MapLength; j++)
            {
                for (int i = 0; i < MapWidth; i++)
                {
                    Console.Write("{0}", field[j, i]);
                }
                Console.WriteLine();
            }
        }
        #endregion
        // 맵 출력부 끝

    }
}
