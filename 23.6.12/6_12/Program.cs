using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[3] { "♠3", "♡K", "♣10" };

            //CallFunc001(str);

            //CallFunc003("Hello", "World", "+", "Hello", "World");

            //CallFunc004(ref str);

            //string[] resultStr;                    // string 배열 선언
            //CallFunc005(str, out resultStr);       // out을 활용해서 값을 넘겨 받음
            //foreach(string result_ in resultStr) 
            //{
            // Console.Write("{0}", result_);
            //}
            // Console.WriteLine();




            // C#과 C++의 연산 순서 차이
            //int number = 0;
            //number = number++; //-> C++ = 1, C# = 0       C#은 메모리에 임시 공간을 만들고 연산 후에 닫아버리기 때문에 반영이 안됨 
            //number += 1;       //-> C++ = 1, C# = 1
            //Console.WriteLine("number는 무슨 값이 들어 있나?? {0}", number);
            // C#과 C++의 연산 순서 차이 끝






            //Class1_Dog myDog = new Class1_Dog();
            //Console.WriteLine("우리집 강아지 이름은 {0}이고, 다리 갯수는 {1}개이다", myDog.dogName, myDog.legCount);


            //myDog.Print_DogDesc();


            //Cat myCat = new Cat(4, "야옹이", "검정색");
            //myCat.Print_MyCat();







            // 객체 지향의 4요소 : 캡슐화, 상속, 

            Slime blueSlime = new Slime();
            blueSlime.Print_Slime_Desc();

            Bat caveBat = new Bat();
            caveBat.Print_Bat_Desc();

            Skeleton skeletonWarrior = new Skeleton();                              
            skeletonWarrior.Initialize("해골병사", 50, 20, 15, 10, "스켈레톤");             // 이런 식으로 초기화를 하면 값을 유동적으로 줄 수 있게된다
            skeletonWarrior.Print_Mon_info();













        }     //// 메인 끝



        //// 네 번째 방법 : 매개변수를 Call by Reference 방식으로 넘기는 것
        //// 매개변수를 통해서 값을 return 한다, 변수가 절대로 비어있지 않도록 하기 위함         ex. 닉네임 등
        static void CallFunc005(string[] str, out string[] outStr) 
        {
            string[] resultString = new string[str.Length + 1];

            for(int i=0; i<str.Length; i++) 
            {
                resultString[i] = str[i];
            }
            resultString[str.Length] = "!";
            outStr = resultString;
        }                //// CallFunc005 끝







        //// 세 번째 방법 : 매개변수를 Call by Reference 방식으로 넘기는 것
        static void CallFunc004(ref string[] str) 
        {
            foreach(string strElement in str) 
            {
                Console.Write("{0}", strElement);
            }
            Console.WriteLine();
        }               //// CallFunc004 끝







        //// 두 번째 방법 : 매개변수를 Call by Value 방식으로 넘기는 것은 똑같음
        //// 그런데 넘겨줄 매개변수를 배열의 요소 형태로 여러개 넘길 수 있다
        static void CallFunc003(params string[] str) 
        {
            foreach (string strElement in str) 
            {
                Console.Write("{0}", strElement);
            
            }
            Console.WriteLine();
        }              //// CallFunc003 끝  








        //// 첫 번째 방법 : 매개변수를 Call by Value 방식으로 넘기는 방법
        static void CallFunc001(string[] str) 
        {
            foreach(string strElement in str) 
            {
                Console.Write("{0}", strElement);
            }
            Console.WriteLine();
        }            //// CallFunc001() 끝

        static void CallFunc002(string[] str)           //// 한 글자씩 넘기기
        {
            foreach (string strElement in str)
            {
                foreach(char char_ in strElement) 
                {
                    Console.Write("{0}", char_);
                }
                Console.Write("");
            }
            Console.WriteLine();
        }            //// CallFunc002() 끝










    }       //// class program 끝
}
