using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _6_21
{
    public class _6_21
    {







        /// <summary>
        /// 이 함수는 매개 변수를 하나 받아서 출력하는 함수입니다
        /// </summary>
        /// <param name="testStr2">이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>
        /// <returns>이 함수가 정상 동작했을 때 true를 return합니다</returns>
        public static bool TestFunc003(string testStr2) 
        {
            Console.WriteLine("TestFunc003를 콜합니다");
            return true;
        }



        /// <summary>
        /// 이 함수는 매개변수를 하나 받아서 출력하는 함수입니다
        /// </summary>
        /// <param name="testStr">이 변수는 문자열로 이루어진 설명을 받아서 저장하는 변수</param>
        public static void TestFunc002(string testStr) 
        {
            Console.WriteLine("TestFunc002를 콜합니다");
        }



        // 함수에는 타인이 읽을 수 있도록 설명을 추가할 수 있다
        // 2가지 방법을 소개
        // 1. attribute 기능을 사용
        [Obsolete ("\n이 함수는 아무런 기능이 없는 함수입니다")]
        public static void TestFunc001()
        {
            Console.WriteLine("TestFunc001를 콜합니다");
        }
    }
}
