using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21
{
    public interface iClickable     // 인터페이스는 무조건 퍼블릭 -> 마찬가지로 상속 받아 사용, 다만 다중상속 가능
    {
        void ClickThisObject(bool isClick_);    // 인터페이스에서는 필드를 사용할 수 없다
                                                // 메서드만 가능, 앞에 public private 안 붙음

    }
}
