using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public partial class Map
    {


        public void TalkToNPC() 
        {
            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.SetCursorPosition(0, 23);
                Console.WriteLine("꼬렛들이 작물들을 다 갉아먹고 있네!                               ");
                Console.ReadKey();

                Console.SetCursorPosition(0, 23);
                Console.WriteLine("혹시 자네는 포켓몬 트레이너인가?                                  ");
                Console.ReadKey();

                Console.SetCursorPosition(0, 23);
                Console.WriteLine("내 부탁 좀 함세, 근처에 있는 내 밭에서 꼬렛을 퇴치해주게!            ");
                Console.WriteLine("                                               (Y / N) ▼");
                userInput = Console.ReadKey();


                if (userInput.Key == ConsoleKey.Y)
                {
                    Console.SetCursorPosition(0, 23);
                    Console.WriteLine("                                                                      ");
                    Console.WriteLine("정말 고맙네!! 기다리고 있겠네!!                          ");
                    Console.ReadKey();
                    receivedQuestCount++;

                    break;
                }
                else if (userInput.Key == ConsoleKey.N)
                {
                    Console.SetCursorPosition(0, 23);
                    Console.WriteLine("                                                                      ");
                    Console.WriteLine("아쉽지만 어쩔 수 없지... 마음이 바뀐다면 다시 오게.         ");
                    Console.ReadKey();

                    break;
                }
                else
                {
                    break;
                }

            }
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");


        }

        public void TalkToNPC2() 
        {


            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("자네 덕분에 꼬렛들이 눈에 띄게 줄었네!                             ");
            Console.ReadKey();

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("고맙네! 포켓몬 트레이너!                                ");
            Console.ReadKey();
            receivedQuestCount--;

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("이건 감사의 표시로 받아주게!                              ");
            Console.ReadKey();

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("당신은 꼬마돌을(를) 받았습니다!                               ");
            Console.ReadKey();

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("이 녀석이 여행에 도움이 되었으면 좋겠네!                               ");
            Console.ReadKey();
            doneQuestCount++;

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");



        }

        public void TalkToNPC3() 
        {
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("꼬마돌은 잘 지내고 있는가?                            ");
            Console.ReadKey();

            Console.SetCursorPosition(0, 23);
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");


        }



    }
}
