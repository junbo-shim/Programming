using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_19
{
    public class Child : Parent
    {
        string strChild = default;

        public override void PrintInfos()
        {
            base.PrintInfos();                      //base -> 부모 클래스 것을 사용하겠다


            number = 10;
            strValue = "This is Child";
            strChild = "Sentence of Child added";

            Console.WriteLine("Parent class -> number : {0} , strValue : {1}, strChild : {2}",
                this.number, this.strValue, this.strChild);     
                                                                //this -> 자식 클래스 것을 사용하겠다 (기본적으로 생략되어 있음)
        }
    }
}
