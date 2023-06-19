using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_19
{
    public class Program
    {
        static void Main(string[] args)
        {




        }


        static void UpcastingDowncasting() 
        {

            Parent myParent = new Parent();
            Child myChild = new Child();

            myParent.PrintInfos();
            myChild.PrintInfos();

            Parent tempParent = myChild;            // 업캐스팅 -> 필요한 이유 : 여러 개의 자식 클래스를 하나로 묶을 것이 필요할 때
            Child tempChild = (Child)tempParent;    // 강제로 형변환해야 다운캐스팅 

            tempParent.PrintInfos();
            tempChild.PrintInfos();

        }






        static void BoxUnbox() 
        {
        
            int number = 10;
            char charValue = 'a';
            string textStr = "Hello World";


            object canSaveAll1 = number;        // object 자료형은 모든 자료형을 담을 수 있는 최상위 자료형
            object canSaveAll2 = charValue;     // int, char, string 같은 하위 변수들을 최상위 변수인 object에 담을 수 있음 -> 박싱
            object canSaveAll3 = textStr;

            int number2 = (int)canSaveAll1;     // object 타입으로 박싱되었기 때문에 int로 다시 넣는 것은 불가능하다
                                                // 그러나 강제 형변환 (자료형)을 앞에 붙이면 정상적으로 출력 가능하다




            var canSaveAnything1 = number;      // var와 object는 다른 타입이다
            var canSaveAnything2 = charValue;   // object -> system.object
            var canSaveAnything3 = textStr;     // var -> 컴파일러의 추적기능을 통해서 자동적으로 타입을 추론 (상황별로 int, char, string, object 등)
                                                // = 리플렉션 (reflection)

            Console.WriteLine(canSaveAll1);         
            Console.WriteLine(canSaveAll2);
            Console.WriteLine(canSaveAll3);
            Console.WriteLine(number2);
        
        }

    }
}
