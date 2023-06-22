using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public partial class Map
    {
        public void IniAndDrawMap()     // 맵 초기화 및 출력 함수
        {


            for (int vertical = 0; vertical < MapLength; vertical++)
            {
                for (int horizon = 0; horizon < MapWidth; horizon++)
                {
                    field[vertical, horizon] = "□";     // 기본적 타일
                }
            }


            for (int j = 0; j < (MapLength - 1) / 3; j++)
            {
                for (int i = 2 * (MapWidth - 1) / 3; i < (MapWidth - 1); i++)
                {

                    field[j, i] = "，";      // 잔디 타일

                }
            }

            for (int vertical = 0; vertical < MapLength; vertical++)
            {
                for (int horizon = 0; horizon < MapWidth; horizon++)
                {

                    if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1) / 2)   // 플레이어의 초기 위치 = 맵 중앙
                    {

                        field[vertical, horizon] = "⊙";     // 플레이어 아이콘

                        playerX = horizon;
                        playerY = vertical;
                    }
                    else if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1) / 3)
                    {

                        field[vertical, horizon] = "◎";

                        npcX = (MapWidth - 1) / 2;
                        npcY = (MapLength - 1) / 3;
                    }
                }
            }


            DrawMap();      // 맵을 그릴 함수


        }


    }
}
