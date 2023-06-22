using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public partial class Map
    {



        const int MapWidth = 30;    //맵 너비
        const int MapLength = 20;   //맵 높이

        int playerX = default;      //플레이어x 좌표 저장용 변수
        int playerY = default;      //플레이어y 좌표 저장용 변수
        public int npcX = default;
        public int npcY = default;

        int receivedQuestCount = default;
        int doneQuestCount = default;



        string[,] field = new string[MapLength, MapWidth];  //맵을 그릴 문자열 초기화


        public void DoMap() // 맵에 대한 것을 한꺼번에 뭉쳐놓을 함수
        {
            IniAndDrawMap();    // 맵 초기화 및 출력 함수
            MoveInMap();
            



        }


















    }
}
