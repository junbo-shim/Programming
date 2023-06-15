using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_15_1
{
    public class Field
    {
        // 배열 및 유저위치 변수, 맵사이즈 변수 정의
        string[,] field = default;
        int map_size = default;
        int user_pos_x = default;
        int user_pos_y = default;

        // 박스 1,2,3 위치 저장용 변수 정의
        int box1_pos_x = default;
        int box1_pos_y = default;
        int box2_pos_x = default;
        int box2_pos_y = default;
        int box3_pos_x = default;
        int box3_pos_y = default;



        public void Make_Field() 
        {
            Console.Write("지도 크기를 입력하세요 (5~15) \n: ");
            while (true)
            {
                
                int.TryParse(Console.ReadLine(), out map_size);

                if (5 <= map_size && map_size <= 15)
                {
                    //Console.WriteLine("필드 초기화?");
                    field = new string[map_size, map_size];       // 맵 사이즈에 맞추어 배열 생성
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("오류! 다시 입력하세요 (5~15) \n: ");
                }
            }



                    //Console.WriteLine("필드 카운트 : {0}", field);
            for (int vertical = 0; vertical < map_size; vertical++)
            {
                for (int horizon = 0; horizon < map_size; horizon++)
                {
                    //Console.WriteLine("필드 카운트 : {0} {1} {2}", map_size, field.GetUpperBound(0), field.GetUpperBound(1));
                    field[vertical, horizon] = ", ";

                    if (horizon == (map_size - 1) / 2 && vertical == (map_size -1 ) / 2)         // 중앙 위치에 유저 생성
                    {
                        field[vertical, horizon] = "0 ";
                        user_pos_x = horizon;
                        user_pos_y = vertical;
                    }
                }
            }

            for(int j=0; j<map_size; j++)               // 맵 사이즈에 맞추어 출력
            {
                for(int i=0; i<map_size; i++) 
                {
                    Console.Write("{0}", field[j, i]);
                }
                Console.WriteLine();
            }
        }

        public void Move_In_Field() 
        {
            // while문 안에 걸리면 계속해서 바뀌므로 밖으로 뺌
            Random random = new Random();
            box1_pos_x = random.Next(0, map_size);
            box1_pos_y = random.Next(0, map_size);
            box2_pos_x = random.Next(0, map_size);
            box2_pos_y = random.Next(0, map_size);
            box3_pos_x = random.Next(0, map_size);
            box3_pos_y = random.Next(0, map_size);

            while (true)
            {
                ConsoleKeyInfo user_Input = Console.ReadKey();
                if (user_Input.Key == ConsoleKey.UpArrow)             // 위방향키 y좌표를 -1 값씩 함, 다만 0일 경우(꼭대기)에는 0
                {
                    if (user_pos_y > 0)
                    {       
                        if (field[(user_pos_y -1) , user_pos_x] == "a" || field[(user_pos_y - 1), user_pos_x] == "b" || field[(user_pos_y - 1), user_pos_x] == "c") { user_pos_y -= 1; }                // 만약 내 y 값 위쪽에 박스들이 없을 경우 움직일 수 있음
                        else if ((user_pos_y - 1) != box2_pos_y) { user_pos_y -= 1; }
                        else if ((user_pos_y - 1) != box3_pos_y) { user_pos_y -= 1; }
                        else if ((user_pos_y - 1) == box1_pos_y) { user_pos_y -= 0; }           // 만약 내 y 값 위쪽에 박스들이 있을 경우 움직일 수 없음
                        else if ((user_pos_y - 1) == box2_pos_y) { user_pos_y -= 0; }
                        else if ((user_pos_y - 1) == box3_pos_y) { user_pos_y -= 0; }
                        else { continue; }                                                      // 혹시 모르는 else 처리
                    }
                    else
                    {
                        user_pos_y = 0;
                    }
                }
                else if (user_Input.Key == ConsoleKey.DownArrow)        // 아래방향키 y좌표를 +1 값씩 함, 다만 map_size -1 일 경우(바닥)에는 map_size -1
                {
                    if (user_pos_y < map_size - 1)
                    {
                        user_pos_y += 1;
                    }
                    else
                    {
                        user_pos_y = map_size - 1;
                    } 
                }
                else if (user_Input.Key == ConsoleKey.LeftArrow)        // 좌측방향키 x좌표를 -1 값씩 함, 다만 0일 경우(좌측 끝)에는 0
                {
                    if (user_pos_x > 0)
                    {
                        user_pos_x -= 1;
                    }
                    else
                    {
                        user_pos_x = 0;
                    }
                }
                else if (user_Input.Key == ConsoleKey.RightArrow)        // 우측방향키 x좌표를 +1 값씩 함, 다만 map_size -1 일 경우(우측 끝)에는 map_size -1
                {
                    if (user_pos_x < map_size - 1)
                    {
                        user_pos_x += 1;
                    }
                    else
                    {
                        user_pos_x = map_size - 1;
                    }
                }
                else if (user_Input.Key == ConsoleKey.Home)              // home키 누르면 초기화
                {
                    Console.Clear();
                    Make_Field();
                }



                for (int y = 0; y < map_size; y++)                     // 바뀐 위치를 다시 기억시키는 for문
                {
                    for (int x = 0; x < map_size; x++)
                    {
                        field[y, x] = ", ";

                        if (x == user_pos_x && y == user_pos_y)
                        {
                            field[y, x] = "0 ";
                        }
                    }
                }

                field[box1_pos_y, box1_pos_x] = "a";
                field[box2_pos_y, box2_pos_x] = "b";
                field[box3_pos_y, box3_pos_x] = "c";


                Console.Clear();                                      // 이전 출력화면 날려주고 다시 맵을 그리는 출력문
                for (int j = 0; j < map_size; j++)
                {
                    for (int i = 0; i < map_size; i++)
                    {
                        Console.Write("{0}", field[j, i]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void Make_Box() // 돌 좌표를 생성하는 메서드
        {


            
            



        
        
        
        }
    }
}
