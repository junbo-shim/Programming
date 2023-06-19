using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_19
{
    public class MonsterBase
    {
        protected string name = default;

        public virtual void PrintInfos() 
        {
            Console.WriteLine("이 몬스터는 {0} 입니다.", this.name);
        
        }

    }
}
