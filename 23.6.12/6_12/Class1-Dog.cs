using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



public struct Cat              // 내가 고양이라는 개체에 대한 여러 변수를 한 곳에서 관리하고 싶을때
{
    int legCount;
    string catName;
    string catColor;


    public Cat(int legCount_, string catName_, string catColor_) 
    {
        // 구조체(클래스) 자신과 동일한 이름을 가진 메서드가 존재
        // =생성자와 소멸자
        // 특징 : 자신과 이름이 똑같고, 리턴 타입이 전혀 없음

        legCount = legCount_;
        catName = catName_;
        catColor = catColor_;
    }

    public void Print_MyCat() 
    {
        Console.WriteLine("우리집 고양이 이름은 {0} 이고, 색은 {1} 이다.", catName, catColor);
    }
}



namespace _6_12
{
    


    public class Class1_Dog       // 클래스 : 구조체보다 상위 개념
    {
        //접근 제한자, 접근 지정자 (public, protected, private)

        public int legCount = 4;
        public string dogName = "멍멍이";
        
        private string dogColor = "하얀색";
        private string dogSound = "왈크왈크";


        public void Print_DogDesc() 
        {
            Console.WriteLine("강아지 색은 {0} 이고, 짖는 소리는 {1}이다.", dogColor, dogSound);
        }

        public static void Print_DogDesc2()     // static을 표시하면 전역함수로 취급 -> 코드 읽고 전역함수,변수 읽고 그 다음에 메인함수가 기능함
        {                                       // static이 메인함수보다 먼저 캐싱하기 때문에 다른 변수가 안들어감
            Console.WriteLine("강아지 이름은 {0} 이고, 색상은 {1} 이다."); 
        }

    }
}
