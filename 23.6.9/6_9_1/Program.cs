using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_9_1
{
    public class Program
    {
        static void Main(string[] args)         // static method는 static 만 부를 수 있음
        {                                       // C#의 매개변수 args를 main 안에 넣어야함

            Random random = new Random();       // 랜덤이라는 자료형이 따로 생김 - 괄호 안이 시드값
            int [] lottos = new int[6];
            random.Next(1, 10);                 // 괄호 안에 값이 최소 최대값
            


            for(int i=0; i<lottos.Length;i++)       // C#에서의 로또번호 값 돌리기, Length로 길이를 알수가 있음
            {
                lottos[i] = random.Next(1, 45);
            }

            Task.Delay(1000).Wait();
            foreach(int lotto_ in lottos) 
            {
                Console.Write("{0}", lotto_);  
            }
            Console.WriteLine();




            int[] numbers = new int[5];         // C#은 내부적으로 초기화 되어있음
            int[,] numbers2 = new int[5, 5];    // C#의 이차원 배열 동적할당

            int valueCount = 0;


            for(int y=0; y<5; y++) 
            {
                for (int x = 0; x < 5; x++)
                {
                    valueCount += 1;
                    numbers2[y, x] = valueCount;

                    //Console.WriteLine("numbers[{0}][{1}] 의 값 : {2} \n", y, x, numbers2[y,x]);
                }
            }

            //for(int y = 0; y<5; y++)
            //{
            //    for(int x=0; x<5; x++)
            //    {
            //        Console.Write("{0} ", numbers2[y, x]);

            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            PrintMyArray(numbers2);
        }







        static void PrintMyArray(int[,] array_) 
        {
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("{0} ", array_[y, x]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }





        static void Des001()
        {
            Console.WriteLine("Hello World! \n");

            string userInput1 = default;
            string userInput2 = default;
            int number = default;
            float floatNumber = default;

            int userNumber1 = default;
            int userNumber2 = default;



            // 여기서 입력을 받음
            userInput1 = Console.ReadLine();
            userInput2 = Console.ReadLine();



            Console.WriteLine("입력 받은 내용을 출력하고 싶어 -> {1}, {0} \n\n", userInput1, userInput2);
            Console.WriteLine("{0} + {1} = {2} \n",
                userInput1, userInput2, userInput1 + userInput2);       // 문자를 그대로 놓음 -> 결과는 input1 input2임


            // 여기서 입력을 숫자로 바꿈 - 3가지 방법 / TryParse가 안전한 방법

            userNumber1 = System.Convert.ToInt32(userInput1);
            userNumber2 = System.Convert.ToInt32(userInput2);


            userNumber1 = int.Parse(userInput1);
            userNumber2 = int.Parse(userInput2);


            int.TryParse(userInput1, out userNumber1);
            int.TryParse(userInput2, out userNumber2);
        }
    }
}
