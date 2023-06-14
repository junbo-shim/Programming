using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_14
{
    public class Print001         // 클래스의 접근 수준이 퍼블릭
    {
        private string message = default;           // 필드의 접근 수준이 제한적

        public void PrintMessage(string localMessage)       //메서드의 접근 수준이 퍼블릭
        {
            message = localMessage;
            Console.WriteLine("이런 걸 출력하겠다 -> {0}", message);
        }

        //public static void PrintMessage() 
        //{
        //    Console.WriteLine("static 메서드에서 인스턴스 필드를 찍어볼 수 있을까? -> {0}", message);  // 변수가 없으므로 불가능한 문장
        
        //}
    }
}
