using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            CustomClass customClass001 = new CustomClass();
            CustomClass customClass002 = null;              // 얕은 복사 -> 주소에서 값을 참조하는 것


            CustomClass customClass001 = new CustomClass();
            CustomClass customClass002 = default;           // 얕은 복사
            CustomClass customClass003 = new CustomClass(); // 깊은 복사 -> 원본의 값을 아예 복사해서 다른 개체가 되는 것, new로 초기화하면 다른 객체

            customClass002 = customClass001;                // 값을 넣으면 얕은 복사

            customClass001.Initialize(0, 1);
            customClass003.Initialize(customClass001.xPos, customClass001.yPos);

            customClass002.PrintPosition();



            customChild001.Initialize(0, 1);

            PrintValue(customChild001);




        }




        static void tuple() 
        {
            // 튜플 선언하는 법
            (int xPos, int yPos) playerPosition = (0, 1);
            playerPosition.xPos = 10;
            playerPosition.yPos = 20;

            Console.WriteLine("Player Position : ({0}, {1})", playerPosition.xPos, playerPosition.yPos);
            (playerPosition.xPos, playerPosition.yPos) = (playerPosition.yPos, playerPosition.xPos);        // 튜플은 스왑쓰고 싶지 않을때 사용할 수 있음
                                                                                                            // 다만 튜플 기능은 메모리를 많이 사용함
        }







        static void SplitDesc() 
        {
        
            string strValue = "I am a boy";
            string[] strArray = strValue.Split(' ');    // 구분자 설정 (스페이스)

            Console.WriteLine("몇 개로 Split 되었는가 -> {0}", strArray.Count());
            Console.WriteLine();

            foreach(string str_ in strArray)            // 구분자가 나올 때마다 따로 스트링 배열로 나눠넣는다
            {
                Console.WriteLine("{0}", str_);
            }
        
        }






        static void GenericDesc() 
        {
        
            List<int> intList = new List<int>();
            CustomClass customClass001 = new CustomClass();
            CustomChild customChild001 = new CustomChild();

            customChild001.Initialize(0, 1);

            PrintValue(customChild001);



            // 값타입인지 참조타입인지 헷갈릴 경우에는 null을 넣어보면 해결된다, null은 참조타입에만 들어감

            customChild001 = null;          // null을 찾는 방법 -> nullable
            if(customChild001 == null) 
            {
                Console.WriteLine("customChild는 null 입니다");
            }
            else 
            {
                customChild001.PrintPosition();
            }                                   // if else 문으로 기본적 체크



            customChild001?.PrintPosition();    // 줄여서 쓸수도 있으나 이 기능은 null을 못 찾아내는 경우가 있으므로 비추천하는 방법

        }



        //static void PrintValue<T>(T anyValue)   // 일반화(generic) 기능 -> 어떤 자료 값이 오더라도 받을 수 있음, 컴파일러가 그때그때마다 타입 추론함(리플렉션) 
        //{
        //    Console.WriteLine("어떤 값이 넘어오든 출력해보겠다 -> {0}", anyValue);
        //}

        static void PrintValue<T>(T anyValue) where T : CustomChild  // var와 다른 점은 일반화는 넘겨받을 범위를 정할 수 있다는 것 
        {
            anyValue.PrintPosition();
        }



        //static void PrintValue(int intValue)    // 함수 오버로딩
        //{
        //    Console.WriteLine("매개 변수로 넘겨받은 값을 출력했다 -> {0}", intValue);
        //}

        //static void PrintValue(float floatValue)    // 함수 오버로딩
        //{
        //    Console.WriteLine("매개 변수로 넘겨받은 값을 출력했다 -> {0}", floatValue);
        //}

        //static void PrintValue(string strValue)    // 함수 오버로딩
        //{
        //    Console.WriteLine("매개 변수로 넘겨받은 값을 출력했다 -> {0}", strValue);
        //}

    }
}
