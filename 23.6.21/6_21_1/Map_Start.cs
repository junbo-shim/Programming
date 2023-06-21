using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21_1
{
    internal partial class Map_Start
    {
        // 상수 값 설정 (맵 가로 세로, 난이도 레벨)
        const int MapWidth = 25;
        const int MapLength = 20;
        const int LevelRandomWall = 60;



        // 유저 인풋, xy좌표 저장 변수, 이동 카운트 변수 선언 
        string userInput = default;
        int playerPosX = default;
        int playerPosY = default;
        int playerMoveCount = default;
        int enemyCount = default;
        Random random = new Random();




        // 맵(2차원배열), 랜덤xy좌표 저장용 배열 선언
        string[,] field = new string[MapLength, MapWidth];
        int[] randomX = new int[LevelRandomWall];
        int[] randomY = new int[LevelRandomWall];

        




        // 실행부 전방으로 뺌
        public void DoMapStart()
        {
            Console.Clear();

            MakeMapStart_First();
            MakeMapStart_Move();
        }


    }
}
