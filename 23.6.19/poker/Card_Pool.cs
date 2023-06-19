using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
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


        List<int> idx_Number;               // 카드 풀의 인덱스를 날리지 않으면서 중복없이 카드를 뽑기 위한 인덱스 숫자 리스트
        List<int> idx_Number_Swap;          // 스왑을 위한 리스트 선언


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



            // 리스트 셔플 로직
            for (int i = 0; i < array_Length; i++)
            {
                int random_Shuffle_Number = random_Number.Next(0, array_Length);

                int temp = default;
                temp = idx_Number[i];
                idx_Number[i] = idx_Number[random_Shuffle_Number];
                idx_Number[random_Shuffle_Number] = temp;
            }

        }


        public void Print_Cards()

        {
            // 컴퓨터 카드 출력
            Console.WriteLine("컴퓨터의 카드는 : ");
            for (int i = com_Draw_Size; i < (com_Draw_Size + player_Draw_Size); i++)
            {
                Console.Write("{0} ", card_Pools[idx_Number[i]]);
            }



            // 플레이어 카드 출력
            Console.WriteLine("\n\n당신의 카드는 : ");
            for (int i = 0; i < player_Draw_Size; i++)
            {
                
                Console.WriteLine("{0}. {1} \n", (i + 1), card_Pools[idx_Number[i]]);
            }
        }



        // 플레이어의 카드를 스왑하는 메서드
        public void Change_Card() 
        {
            for (int i = 0; i < player_Draw_Size; i++)
            {
                idx_Number_Swap.Add(idx_Number[i]);     // 섞인 idx_Number를 idx_Number_Swap 리스트에 넣기
            } 

            int swap_Count = default;
            Console.WriteLine("바꿀 카드를 2장 고르세요");
            while (swap_Count < 2)
            {
                ConsoleKeyInfo Input_key = Console.ReadKey();
                switch (Input_key.Key)
                {
                    case ConsoleKey.D1:

                        Change_Card(idx_Number_Swap[0], idx_Number_Swap[5]);
                        idx_Number_Swap.Remove(idx_Number_Swap[5]);
                        Console.Write("당신은 {0}을 집어넣고 {1}을 받았습니다",
                            card_Pools[idx_Number_Swap[0]], card_Pools[idx_Number_Swap[5]]);
                        break;


                    case ConsoleKey.D2:

                        Change_Card(idx_Number_Swap[1], idx_Number_Swap[5]);
                        idx_Number_Swap.Remove(idx_Number_Swap[5]);
                        Console.Write("당신은 {0}을 집어넣고 {1}을 받았습니다",
                            card_Pools[idx_Number_Swap[1]], card_Pools[idx_Number_Swap[5]]);
                        break;


                    case ConsoleKey.D3:

                        Change_Card(idx_Number_Swap[2], idx_Number_Swap[5]);
                        idx_Number_Swap.Remove(idx_Number_Swap[5]);
                        Console.Write("당신은 {0}을 집어넣고 {1}을 받았습니다",
                            card_Pools[idx_Number_Swap[2]], card_Pools[idx_Number_Swap[5]]);
                        break;


                    case ConsoleKey.D4:

                        Change_Card(idx_Number_Swap[3], idx_Number_Swap[5]);
                        idx_Number_Swap.Remove(idx_Number_Swap[5]);
                        Console.Write("당신은 {0}을 집어넣고 {1}을 받았습니다",
                            card_Pools[idx_Number_Swap[3]], card_Pools[idx_Number_Swap[5]]);
                        break;


                    case ConsoleKey.D5:

                        Change_Card(idx_Number_Swap[4], idx_Number_Swap[5]);
                        idx_Number_Swap.Remove(idx_Number_Swap[5]);
                        Console.Write("당신은 {0}을 집어넣고 {1}을 받았습니다",
                            card_Pools[idx_Number_Swap[4]], card_Pools[idx_Number_Swap[5]]);
                        break;


                    default:    
                        continue;
                }
                swap_Count++;
            } 
        }















            //idx_Number.Clear();
        



            public void Change_Card(int first, int second) 
        {
            int temp = default;
            temp = first;
            first = second;
            second = temp;
        }





            //// 
            //for (int i = 0; i < (idx_Number.Count)-(player_Draw_Size); i++)
            //{
            //    idx_Number.Remove(idx_Number[i]);
            //    Console.WriteLine("플레이어의 {0} 번째 카드는 {1}", i, card_Pools[idx_Number[i]]);
            //}

            //for (int i = 0; i < com_Draw_Size; i++) 
            //{
            //    Console.WriteLine("컴퓨터의 {0} 번째 카드는 {1}", i, card_Pools[idx_Number[i]]);
            //}






        //public void Print_Card_Table() 
        //{
        //    Console.WriteLine("당신의 카드는 {0} {1} {2} {3} {4} {5} {6}",
        //        card_Pools[random_Idx1], card_Pools[random_Idx2], card_Pools[random_Idx3], card_Pools[random_Idx4],
        //        card_Pools[random_Idx5], card_Pools[random_Idx6], card_Pools[random_Idx7]);

        //    Console.WriteLine("컴퓨터의 카드는 {0} {1} {2} {3} {4} {5} {6}",
        //        card_Pools[random_Idx8], card_Pools[random_Idx9], card_Pools[random_Idx10], card_Pools[random_Idx11],
        //        card_Pools[random_Idx12], card_Pools[random_Idx13], card_Pools[random_Idx14]);
        //}



    }
}
