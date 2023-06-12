using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_12
{


    // 캡슐화 -> 필드를 private로 묶어서 외부에서 접근 불가능하도록 하겠다는 의미
    // protected -> 상속받은 자식 클래스에서는 접근 가능
    public class MonsterBase
    {


        protected string Name;
        protected string Type;
        protected int HP;
        protected int MP;
        protected int DMG;
        protected int DEF;


        public virtual void Initialize(string Name, int HP, int MP, int DMG, int DEF, string Type)      // 초기화
        {                                                                                               // 버츄얼을 써주면 자식클래스에서 오버라이드가능 -> 다형성
            this.Name = Name;
            this.Type = Type;
            this.HP = HP;
            this.MP = MP;
            this.DMG = DMG;
            this.DEF = DEF;
        }


        public virtual void Print_Mon_info()
        {
            Console.Write("이 몬스터의 이름은 {0}이며, 몬스터타입은 {1} 이다.", Name, Type);
            Console.WriteLine();
            Console.Write("HP : {0}, MP : {1}, DMG : {2}, DEF : {3}", HP, MP, DMG, DEF);
            Console.WriteLine();
            Console.WriteLine();
        }



        public void Print_Overloading_Test(int textStr)             // 함수 오버로딩 -> 부모 클래스와 상관없음
        {
            Console.WriteLine("함수 찍힌다 -> {0}", textStr);
        }

        public void Print_Overloading_Test(out int number)          // 함수 오버로딩
        {
            Console.WriteLine("함수 찍힌다");
            number = 10;
        }
    }
}
