using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21_1
{
    internal partial class Map_Start
    {

        // 맵의 초기 상태 정의 및 출력부
        #region 초기 맵 정의 및 출력
        public void MakeMapStart_First()
        {

            for (int vertical = 0; vertical < MapLength; vertical++)
            {
                for (int horizon = 0; horizon < MapWidth; horizon++)
                {
                    field[vertical, horizon] = "□"; // 길
                    if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1) / 2)
                    {
                        field[vertical, horizon] = "●"; // 플레이어

                        playerPosX = horizon;
                        playerPosY = vertical;
                    }
                    else if (vertical == 0)
                    {
                        field[vertical, horizon] = "■"; // 위쪽 벽
                    }
                    else if (vertical == (MapLength - 1))
                    {
                        field[vertical, horizon] = "■"; // 아래쪽 벽
                    }
                    else if (horizon == 0)
                    {
                        field[vertical, horizon] = "■"; // 좌측 벽
                    }
                    else if (horizon == (MapWidth - 1))
                    {
                        field[vertical, horizon] = "■"; // 우측 벽
                    }

                    #region 포탈
                    //else if (horizon == (MapWidth - 1) && vertical == (MapLength - 1) / 2)  // 동
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == 0 && vertical == (MapLength - 1) / 2)  // 서
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == (MapWidth - 1) / 2 && vertical == (MapLength - 1))  // 남
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    //else if (horizon == (MapWidth - 1) / 2 && vertical == 0)  // 북
                    //{
                    //    field[vertical, horizon] = "♨";
                    //}
                    #endregion
                }
            }


            DrawMap();

        }
        #endregion
        // 맵의 초기 상태 정의 및 출력부 끝

    }
}
