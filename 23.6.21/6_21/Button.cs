using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_21
{
    public interface Button : iClickable
    //public class Button : Clickable
    {
        public void ClickThisObject(bool isClick_) 
        {
            base.ClickThisObject(isClick_);
        }
        public void TestFunc001() 
        {
            Console.WriteLine("함수 테스트");
        }
    }
}
