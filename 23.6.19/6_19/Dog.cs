using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_19
{
    public partial class Dog : MonsterBase  // partial class
    {
        public override void PrintInfos() 
        {
            this.name = "강아지";
            base.PrintInfos;
        }

    }
}
