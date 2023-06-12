using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_12_1
{
    public class GuessGame
    {




        public void Alphabet_Array()
        {

            Random random = new Random();                   // 랜덤이라는 자료형이 따로 생김 - 괄호 안이 시드값
            int[] alphabet = new int[5];
            random.Next(65, 90);                            // 괄호 안에 값이 최소 최대값


            for (int i = 0; i < 5; i++)                     // C#에서의 로또번호 값 돌리기, Length로 길이를 알수가 있음
            {
                alphabet[i] = random.Next(65,90);
            }


            char userinput = default;
            userinput = Console.ReadLine()[0];
            Console.Write("입력문자 : {0}", userinput);

            while (true)
            {
                if (userinput == alphabet[0]) 
                {
                    Console.Write("맞췄습니다!");
                    Console.WriteLine();
                    Console.Write("첫 번째 글자는 {0} 입니다.", alphabet[0]);
                }
                else if (userinput > alphabet[0])
                {
                    Console.Write("틀렸습니다!");
                    Console.WriteLine();
                    Console.Write("입력하신 글자보다 앞쪽입니다.");
                }
                else if (userinput < alphabet[0]) 
                {
                    Console.Write("틀렸습니다!");
                    Console.WriteLine();
                    Console.Write("입력하신 글자보다 뒤쪽입니다.");
                }
            }
        }



        public void Welcome()
        {
            Console.Write("비밀 코드 맞추기 게임");
            Console.WriteLine();
            Console.Write("비밀 코드는 5개의 대문자 알파벳으로 이루어져 있습니다.");
            Console.WriteLine();
            Console.Write("첫 번째 글자를 추측해보세요");
            Console.WriteLine();
        }



        public void User_Input()
        {
            char userinput = default;
            userinput = Console.ReadLine()[0];
            Console.Write("입력문자 : {0}", userinput);

            while (true)
            {
                if (userinput == )







            }







        }


        

    }
}
