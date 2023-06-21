using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _6_21_1
{
    internal partial class Map_Start
    {
 


        // 플레이어 이동 시의 좌표 변화 및 출력부
        #region 이동 좌표 변화 및 출력
        public void CreateEnemy()
        {
            if (playerMoveCount == 6) 
            {
                field[randomY[0]-1, randomX[0]-1] = "⊙";
                enemyCount++;
                playerMoveCount = 0;
            }
            else if (0 <= playerMoveCount && playerMoveCount < 6) 
            {
                playerMoveCount++;
            }
        }
        #endregion
        // 플레이어 이동 시의 좌표 변화 및 출력부 끝
    }
}
