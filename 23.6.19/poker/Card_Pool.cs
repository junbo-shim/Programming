using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace poker
{
    public class Card_Pool
    {

        const int user_start_point = 2000;  // 플레이어 포인트
        int user_point = default;           // 게임 중 변화되는 플레이어 포인트 변수
        int user_bet = default;             // 가변적인 플레이어 베팅 변수

        const int player_Draw_Size = 7;     // 플레이어 패의 숫자
        const int com_Draw_Size = 7;        // 컴퓨터 패의 숫자


        string[] card_Pools = new string[]  // 카드 풀의 배열 (무늬 및 숫자 비교를 인덱스로 해결)
         { "♣2", "◇2", "♡2", "♠2", "♣3", "◇3", "♡3", "♠3", "♣4", "◇4", "♡4", "♠4",
           "♣5", "◇5", "♡5", "♠5", "♣6", "◇6", "♡6", "♠6", "♣7", "◇7", "♡7", "♠7",
           "♣8", "◇8", "♡8", "♠8", "♣9", "◇9", "♡9", "♠9", "♣10", "◇10", "♡10", "♠10",
           "♣J", "◇J", "♡J", "♠J", "♣Q", "◇Q", "♡Q", "♠Q", "♣K", "◇K", "♡K", "♠K", "♣A", "◇A", "♡A", "♠A" };




        List<int> idx_Number = new List<int>();               // 카드 풀의 인덱스를 날리지 않으면서 중복없이 카드를 뽑기 위한 인덱스 숫자 리스트
        List<int> idx_Player_Hand_Draw = new List<int>();          // 핸드에 있는 카드의 인덱스만 따서 저장하는 리스트
        List<int> idx_Player_Hand_Sorted = new List<int>();          // 핸드에 있는 카드의 인덱스만 따서 저장하는 리스트
        List<int> idx_Com_Hand_Draw = new List<int>();
        List<int> idx_Com_Hand_Sorted = new List<int>();




        #region 카드풀 만들기
        // 카드 풀 만드는 메서드
        public void Make_Card_Pool()
        {
            int array_Length = card_Pools.GetLength(0);     // 카드 풀의 크기를 array_Length 변수에 담음 (= 52)

            Random random_Number = new Random();            // 랜덤 on




            // 인덱스 숫자 0 ~51 리스트 생성
            idx_Number = new List<int>();

            for (int i = 0; i < array_Length; i++)
            {
                idx_Number.Add(i);
            }



            // 인덱스 숫자 리스트 셔플
            for (int i = 0; i < array_Length; i++)
            {
                int random_Shuffle_Number = random_Number.Next(0, array_Length);

                int temp = default;
                temp = idx_Number[i];
                idx_Number[i] = idx_Number[random_Shuffle_Number];
                idx_Number[random_Shuffle_Number] = temp;
            }
        }
        #endregion



        #region 카드풀 출력
        public void Print_Cards()

        {
            // 컴퓨터 카드 출력
            Console.WriteLine("컴퓨터의 카드는 : ");
            for (int i = com_Draw_Size; i < (com_Draw_Size + player_Draw_Size); i++)
            {
                Console.Write("{0} ", card_Pools[idx_Number[i]]);
                idx_Com_Hand_Draw.Add(idx_Number[i]);
            }
            Console.WriteLine(string.Join(", ", idx_Com_Hand_Draw));                            // for 문 안쓰고 리스트 출력
            List<int> idx_Com_Hand_Sorted = idx_Com_Hand_Draw.OrderByDescending(i => i).ToList();     // 내림차순 정렬
            Console.WriteLine(string.Join(", ", idx_Com_Hand_Sorted));



            // 플레이어 카드 뽑기 (7장)
            for (int i = 0; i < player_Draw_Size; i++)
            {
                idx_Player_Hand_Draw.Add(idx_Number[i]);
            }


            // 플레이어 카드 출력 (5장만 보여주기)
            Console.WriteLine("\n\n당신의 카드는 : ");
            for (int i = 0; i < player_Draw_Size - 2; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("{0}. {1} \n", (i + 1), card_Pools[idx_Number[i]]);
            }
            Console.WriteLine(string.Join(", ", idx_Player_Hand_Draw));


        }
        #endregion



        #region 플레이어 카드 교환
        // 플레이어의 카드를 스왑하는 메서드
        public void Change_Card()
        {
            int swap_Count = default;
            Console.WriteLine("바꿀 카드를 1장씩 총 2장 고르세요\n1~5를 눌러 선택하고 6을 누르면 스킵합니다\n");
            while (swap_Count < 2)
            {
                int user_Input = default;

                user_Input = int.Parse(Console.ReadLine());


                if(1 <= user_Input && user_Input <= 5) 
                {
                    Swap(idx_Player_Hand_Draw[user_Input - 1], idx_Player_Hand_Draw[5]);

                    Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
                        card_Pools[idx_Player_Hand_Draw[user_Input - 1]], card_Pools[idx_Player_Hand_Draw[5]]);

                    idx_Player_Hand_Draw.Remove(idx_Number[user_Input-1]);
                }
                else if(user_Input == 6) 
                {
                    continue;
                }
                else 
                {
                    swap_Count--;
                    continue;
                }

                swap_Count++;



                Console.WriteLine(string.Join(", ", idx_Player_Hand_Draw));


            }

            List<int> idx_Player_Hand_Sorted = idx_Player_Hand_Draw.OrderByDescending(a => a).ToList();
            Console.WriteLine(string.Join(",\n ", idx_Player_Hand_Sorted));

            Console.WriteLine("\n\n당신의 최종 카드는 : ");
            for (int i = 0; i < player_Draw_Size - 2; i++)
            {
                Console.WriteLine("{0}. {1} \n", (i + 1), card_Pools[idx_Player_Hand_Sorted[i]]);
            }
        }
        #endregion



        //idx_Number.Clear();




        public void Swap(int first, int second)
        {
            int temp = default;
            temp = first;
            first = second;
            second = temp;
        }

        

    //            switch (Input_key.Key)
    //            {
    //                case ConsoleKey.D1:

    //                    Thread.Sleep(1000);
    //                    if (swap_Count == 0)
    //                    {
    //                        Swap(ref card_Pools[idx_Number[0]], ref card_Pools[idx_Number[5]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[5]], card_Pools[idx_Number[0]]);
    //                        idx_Player_Hand1.Remove(idx_Number[5]);
    //                    }
    //                    else 
    //                    {
    //                        Swap(ref card_Pools[idx_Number[0]], ref card_Pools[idx_Number[6]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[6]], card_Pools[idx_Number[0]]);
    //                        idx_Player_Hand1.Remove(idx_Number[6]);
    //                    }
    //                    break;


    //                case ConsoleKey.D2:

    //                    Thread.Sleep(1000);
    //                    if (swap_Count == 0)
    //                    {
    //                        Swap(ref card_Pools[idx_Number[1]], ref card_Pools[idx_Number[5]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[5]], card_Pools[idx_Number[1]]);
    //                        idx_Player_Hand1.Remove(idx_Number[5]);
    //                    }
    //                    else
    //                    {
    //                        Swap(ref card_Pools[idx_Number[1]], ref card_Pools[idx_Number[6]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[6]], card_Pools[idx_Number[1]]);
    //                        idx_Player_Hand1.Remove(idx_Number[6]);
    //                    }
    //                    break;


    //                case ConsoleKey.D3:

    //                    Thread.Sleep(1000);
    //                    if (swap_Count == 0)
    //                    {
    //                        Swap(ref card_Pools[idx_Number[2]], ref card_Pools[idx_Number[5]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[5]], card_Pools[idx_Number[2]]);
    //                        idx_Player_Hand1.Remove(idx_Number[5]);
    //                    }
    //                    else
    //                    {
    //                        Swap(ref card_Pools[idx_Number[2]], ref card_Pools[idx_Number[6]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[6]], card_Pools[idx_Number[2]]);
    //                        idx_Player_Hand1.Remove(idx_Number[6]);
    //                    }
    //                    break;


    //                case ConsoleKey.D4:

    //                    Thread.Sleep(1000);
    //                    if (swap_Count == 0)
    //                    {
    //                        Swap(ref card_Pools[idx_Number[3]], ref card_Pools[idx_Number[5]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[5]], card_Pools[idx_Number[3]]);
    //                        idx_Player_Hand1.Remove(idx_Number[5]);
    //                    }
    //                    else
    //                    {
    //                        Swap(ref card_Pools[idx_Number[3]], ref card_Pools[idx_Number[6]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[6]], card_Pools[idx_Number[3]]);
    //                        idx_Player_Hand1.Remove(idx_Number[6]);
    //                    }
    //                    break;


    //                case ConsoleKey.D5:

    //                    Thread.Sleep(1000);
    //                    if (swap_Count == 0)
    //                    {
    //                        Swap(ref card_Pools[idx_Number[4]], ref card_Pools[idx_Number[5]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[5]], card_Pools[idx_Number[4]]);
    //                        idx_Player_Hand1.Remove(idx_Number[5]);
    //                    }
    //                    else
    //                    {
    //                        Swap(ref card_Pools[idx_Number[4]], ref card_Pools[idx_Number[6]]);

    //                        Console.Write("\n당신은 {0}을 집어넣고 {1}을 받았습니다",
    //                            card_Pools[idx_Number[6]], card_Pools[idx_Number[4]]);
    //                        idx_Player_Hand1.Remove(idx_Number[6]);
    //                    }
    //                    break;


    //                default:    
    //                    continue;

    }
}
