using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21
{

    // 무언가 클릭이 가능한 오브젝트를 만들고 싶을 때 사용할 클래스
    abstract public class Clickable     // abstract가 붙으면 인스턴스화 불가능 -> 무조건 상속 받아 사용
    {
        bool isClickOk = false;

        public virtual void ClickThisObject(bool isClick_) 
        {
            isClickOk = isClick_;

            Console.WriteLine("당신은 이 오브젝트를 클릭했습니다");
        }
    }
}
