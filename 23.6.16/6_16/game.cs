using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _6_16
{
    public class game
    {

        //#region 필드

        // 배열 및 유저위치 변수, 맵사이즈 변수 정의
        //int[,] field = default;
        //int map_size = default;
        //int user_pos_x = default;
        //int user_pos_y = default;
        //int one_x = default;
        //int one_y = default;


        // 박스 1,2,3 위치 저장용 변수 정의
        //int one_pos_x = default;
        //int one_pos_y = default;

        //#endregion


        //public void Make_Field()
        //{

        //    #region 맵 생성
        //    Console.Write("지도 크기를 입력하세요 (5~15) \n: ");
        //    while (true)
        //    {

        //        int.TryParse(Console.ReadLine(), out map_size);

        //        if (5 <= map_size && map_size <= 15)
        //        {
        //            Console.WriteLine("필드 초기화?");
        //            field = new int[map_size, map_size];       // 맵 사이즈에 맞추어 배열 생성
        //            break;
        //        }
        //        else
        //        {
        //            Console.Clear();
        //            Console.Write("오류! 다시 입력하세요 (5~15) \n: ");
        //        }
        //    }
        //    #endregion

        //    #region 초기 필드 값 저장
           
        //    for (int vertical = 0; vertical < map_size; vertical++)
        //    {
        //        for (int horizon = 0; horizon < map_size; horizon++)
        //        {
                    
        //            field[vertical, horizon] = 0;

        //            if (horizon == (map_size - 1) / 2 && vertical == (map_size - 1) / 2)         // 중앙 위치에 유저 생성
        //            {
        //                field[vertical, horizon] = 1;
        //                user_pos_x = horizon;
        //                user_pos_y = vertical;
        //            }
        //        }
        //    }
        //    #endregion

        //    #region 초기 필드 값 출력
        //    for (int j = 0; j < map_size; j++)               // 맵 사이즈에 맞추어 출력
        //    {
        //        for (int i = 0; i < map_size; i++)
        //        {
        //            Console.Write("{0, 3}", field[j, i]);
        //        }
        //        Console.WriteLine();
        //    }
        //    #endregion
        //}

        //public void Move_In_Field()
        //{
        //    while (true)
        //    {
        //        ConsoleKeyInfo user_Input = Console.ReadKey();
        //        if (user_Input.Key == ConsoleKey.DownArrow)        // 아래방향키 y좌표를 +1 값씩 함, 다만 map_size -1 일 경우(바닥)에는 map_size -1
        //        {
        //            if (user_pos_y < map_size - 1)
        //            {
        //                user_pos_y += 1;
        //            }
        //            else
        //            {
        //                user_pos_y = map_size - 1;
        //            }
        //        }
        //        else if (user_Input.Key == ConsoleKey.RightArrow)        // 우측방향키 x좌표를 +1 값씩 함, 다만 map_size -1 일 경우(우측 끝)에는 map_size -1
        //        {
        //            if (user_pos_x < map_size - 1)
        //            {
        //                user_pos_x += 1;
        //            }
        //            else
        //            {
        //                user_pos_x = map_size - 1;
        //            }
        //        }
        //        else if (user_Input.Key == ConsoleKey.Home)              // home키 누르면 초기화
        //        {
        //            Console.Clear();
        //            Make_Field();
        //        }

        //        for (int y = 0; y < map_size; y++)                     // 바뀐 위치를 다시 기억시키는 for문
        //        {
        //            for (int x = 0; x < map_size; x++)
        //            {
        //                field[y, x] = 0;

        //                if (x == user_pos_x && y == user_pos_y)
        //                {
        //                    field[y, x] = 1;
        //                }
        //            }
        //        }

        //        Make_One();


        //        Console.Clear();                                      // 이전 출력화면 날려주고 다시 맵을 그리는 출력문
        //        for (int j = 0; j < map_size; j++)
        //        {
        //            for (int i = 0; i < map_size; i++)
        //            {
        //                Console.Write("{0, 3}", field[j, i]);
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}

        //public void Make_One()  // 랜덤한 좌표값 생성해서 1로 바꿈
        //{
        //    Random random = new Random();

        //     랜덤 y 좌표 저장
        //    int a = 0;
        //    while (a<3)
        //    {
        //        one_x = random.Next(0, map_size);    // 랜덤 x 좌표 저장
        //        one_y = random.Next(0, map_size);

        //        if (field[one_y, one_x] == 0) // 배열[] = 0 일때 1로 바꿈
        //        {
        //            field[one_y, one_x] = 1;
        //            a++;
                 
        //        }   
        //    }
        //}























































        int[,] field = default;
        int map_size = default;
        int one_x1 = default;
        int one_y1 = default;
        int one_x2 = default;
        int one_y2 = default;
        int one_x3 = default;
        int one_y3 = default;


        public void Make_Field()    // 지도 크기 설정 및 루프
        {
            Console.WriteLine("지도 크기를 입력하세요 (8~20)");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out map_size);
                if (8 <= map_size && map_size <= 20)
                {
                    field = new int[map_size, map_size];
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write("오류! 다시 입력하세요 (8~20) \n: ");
                }
            }



            for (int vertical = 0; vertical < map_size; vertical++)
            {
                for (int horizon = 0; horizon < map_size; horizon++)
                {
                    field[vertical, horizon] = 0; 
                }
            }


            for (int j = 0; j < map_size; j++)
            {
                for (int i = 0; i < map_size; i++)
                {
                    Console.Write("{0, 3}", field[j, i]);
                }
                Console.WriteLine();
            }

        }


        public void Make_One()  // 랜덤한 좌표값 생성해서 1로 바꿈
        {
            Random random = new Random();

            one_x1 = random.Next(0, map_size-1);    // 랜덤 x 좌표 저장
            one_y1 = random.Next(0, map_size-1);    // 랜덤 y 좌표 저장
            one_x2 = random.Next(0, map_size-1);
            one_y2 = random.Next(0, map_size-1);
            one_x3 = random.Next(0, map_size-1);
            one_y3 = random.Next(0, map_size-1);

            field[one_y1, one_x1] = 1;
            field[one_y2, one_x2] = 1;
            field[one_y3, one_x3] = 1;


            Console.Clear();        // 바뀐 맵 출력
            for (int j = 0; j < map_size; j++)
            {
                for (int i = 0; i < map_size; i++)
                {
                    Console.Write("{0, 3}", field[j, i]);
                }
                Console.WriteLine();
            }
        }



        public void Move_One()
        {

            while (true)
            {
                ConsoleKeyInfo user_Input = Console.ReadKey();  // 키 설정
                if (user_Input.Key == ConsoleKey.Tab) 
                { 
                    Make_One();
                }
                     
                else if (user_Input.Key == ConsoleKey.RightArrow)
                {

                    for (int j = 0; j < map_size-1; j++)
                    {   
                        
                        int sum = default;
                        
                        for (int i = 0; i < map_size - 1; i++)
                        {
                            if (field[j, i] == 0)
                            {
                                continue;
                            }
                            else if (field[j,i] == 1) 
                            {
                                sum += 1;
                                field[j, i] = 0; 
                            }
                        }
                        Console.WriteLine("{0}", sum); // 체크용
                        field[j, map_size - 1] = sum;
                    }
                }

                else if (user_Input.Key == ConsoleKey.DownArrow)
                {

                    for (int i = 0; i < map_size-1; i++)
                    {
                        int sum = default;

                        for (int j = 0; j < map_size-1; j++)
                        {
                            if (field[j, i] == 0)
                            {
                                continue;
                            }
                            else if (field[j, i] == 1)
                            {
                                sum += 1;
                                field[j, i] = 0;
                            }
                        }
                        field[map_size - 1, i] = sum;
                    }
                }

                else if (user_Input.Key == ConsoleKey.Home)
                {
                    Console.Clear();
                    Make_Field();
                }


                for (int y = 0; y < map_size; y++)
                {
                    for (int x = 0; x < map_size; x++)
                    {
                        Console.Write("{0}", field[y, x]);
                    }
                }



                Console.Clear();        // 바뀐 맵 출력
                for (int j = 0; j < map_size; j++)
                {
                    for (int i = 0; i < map_size; i++)
                    {
                        Console.Write("{0, 3}", field[j, i]);
                    }
                    Console.WriteLine();
                }

            }
        }


    }
}
