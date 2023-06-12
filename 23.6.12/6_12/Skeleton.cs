using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_12
{
    public class Skeleton : MonsterBase      // 상속
    {
        public override void Initialize(string Name, int HP, int MP, int DMG, int DEF, string Type)      
        {                                                                                               
            base.Initialize(Name, HP, MP, DMG, DEF, Type);
        }

        public override void Print_Mon_info()
        {
            base.Print_Mon_info();
        }
    }
}
