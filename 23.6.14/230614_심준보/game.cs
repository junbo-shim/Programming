using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _6_13
{
    public class Game
    {
        // 유저 x 값 저장용 변수
        int user_x;
        // 유저 y 값 저장용 변수
        int user_y;
        // 맵 사이즈 저장용 변수
        int map_size = 0;

        string[,] field = new string[5,5];
       


        // 생성된 코인의 갯수
        int coin_number = default;
        // 코인 먹은 갯수 변수
        int got_coin_number = default;
        // 코인 생성을 위한 루프 카운트 변수
        int coin_loop_count = default;
        // 코인 x 값 저장용 변수
        int coin_x;
        // 코인 y 값 저장용 변수
        int coin_y;


                                                                        //int[] coinData_x = new int[4];
                                                                        //int[] coinData_y = new int[4];
        public void Make_Field()
        {
            Console.WriteLine("맵 크기를 입력하세요 : \n");
            while (true)
            {
                int.TryParse(Console.ReadLine(), out map_size);
                if(map_size >=5 && map_size <= 15) 
                {
                    string[,] field = new string[map_size, map_size];
                    break;
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("오류! 다시 입력하세요\n");
                }
            }

            
            // 이중 for문으로 이차원 배열 만들기
            for (int j = 0; j < map_size; j++)
            {
                for (int i = 0; i < map_size; i++)
                {
                    // 기본적으로 * 출력
                    field[j, i] = "* ";

                    if (j == 2 && i == 2)
                    {
                        // i,j가 2일 때 0을 그림
                        field[j, i] = "0 ";
                        // 그때의 i,j의 값을 유저 좌표로 넘겨줌 -> 즉 지금 상태는 user_x = 2, user_y = 2
                        user_x = i;
                        user_y = j;
                    }
                }
            }

            Console.Clear();
            // 이중 for문으로 이차원 배열 출력
            for (int j = 0; j < map_size; j++)
            {
                for (int i = 0; i < map_size; i++)
                {
                    // 출력할 배열 좌표
                    Console.Write("{0}", field[j, i]);
                }
                //한줄 띄우기
                Console.WriteLine();
            }

        }



        //public void Swap(ref string first, ref string second)                   // 셔플 함수
        //{
        //    string temp = default;
        //    temp = first;
        //    first = second;
        //    second = temp;
        //}



        public void Move_In_Field()
        {

            while (true)
            {
                // 키 입력 조건문 무조건 외우기
                ConsoleKeyInfo user_input = Console.ReadKey();
                if (user_input.Key == ConsoleKey.UpArrow)
                {
                    if(user_y > 0)
                    { 
                        user_y -= 1;
                    }
                    else 
                    {
                        user_y = 0;
                    }
                }
                else if (user_input.Key == ConsoleKey.DownArrow)
                {
                    if(user_y < map_size-1) 
                    {
                        user_y += 1;
                    }
                    else 
                    {
                        user_y = (map_size - 1);
                    }
                }
                else if (user_input.Key == ConsoleKey.LeftArrow)
                {
                    if (user_x > 0) 
                    {
                        user_x -= 1;
                    }
                    else 
                    {
                        user_x = 0;
                    }
                }
                else if (user_input.Key == ConsoleKey.RightArrow)
                {
                    if (user_x < map_size-1) 
                    {
                        user_x += 1;
                    }
                    else 
                    {
                        user_x = (map_size - 1);
                    }
                }

                // 랜덤값 정의
                Random Random_Number = new Random();
                Random_Number.Next(0, map_size);
                // 코인 xy에 랜덤값 입력 



                // 코인 루프 카운트 -> 움직임 판정이 끝나고 바로 들어간다
                coin_loop_count += 0;

                if (coin_loop_count > 3) // 코인루프카운트가 4이상일때
                {
                    if (coin_number == 0) // 코인 넘버가 0이라면
                    {

                        while (true)
                        {
                            coin_x = Random_Number.Next(0, map_size);
                            coin_y = Random_Number.Next(0, map_size);

                            if (coin_x == user_x && coin_y == user_y) // 유저좌표와 코인좌표가 같으면 스킵
                            {
                                continue;
                            }
                            else                                     // 아니라면 코인이 하나 생기고 루프 카운터가 0으로 초기화 된다
                            {
                                coin_number = 1;
                                coin_loop_count = 0;
                                break;
                            }
                        }
                    }
                }

                if(coin_x == user_x && coin_y == user_y)         // 코인좌표와 유저좌표가 같을시
                {                                                // 코인 넘버가 0이 되며 먹은 코인수가 올라간다
                    coin_number = 0;
                    got_coin_number += 0;
                }





                // 유저 좌표가 변한 다음 배열 정의
                for (int j = 0; j < map_size; j++)
                {
                    for (int i = 0; i < map_size; i++)
                    {
                        field[j, i] = "* ";

                        if (j == user_y && i == user_x)
                        {
                            field[j, i] = "0 ";
                                                                                //코인먹었다.
                                                                                // cointCnt--;
                                                                                // if 먹은좌표 == cointData 좌표 예) 1번 배열
                                                                                // 1번의 좌표 없어짐
                                                                                // 2번 -> 1번

                        }
                        if (coin_number == 1)
                        {
                            field[coin_y, coin_x] = "ⓒ";

                        }




                        //코인좌표를 저장
                        //if (coinCnt<4)
                        //        {
                        //            coinData_x[coinCnt] = coinCode_x;
                        //            coinData_y[coinCnt] = coinCode_y;
                        //        }

                        //coinCnt++;






                    }

                }


                Console.Clear();
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

    }

}