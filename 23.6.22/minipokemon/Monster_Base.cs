using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minipokemon
{
    public class Monster
    {
        public string monsterName { get; protected set; }
        public int monsterHP { get; protected set; }
        public int monsterMAXHP { get; protected set; }
        public int monsterBaseATK { get; protected set; }
        public string monsterSkillName { get; protected set; }



        public virtual void IniMonster(string monsterName_, int monsterHP_, int monsterMAXHP_, int monsterBaseATK_, string monsterSkillName_) 
        {
            monsterName = monsterSkillName_;
            monsterHP = monsterHP_;
            monsterMAXHP = monsterMAXHP_;
            monsterBaseATK = monsterBaseATK_;
            monsterSkillName = monsterSkillName_;
        }



        public virtual void DoMonsterAtt(string monsterName, int monsterBaseATK) 
        {
            Console.WriteLine("{0}은(는) 공격했다! {1}의 데미지를 가했다!", monsterName, monsterBaseATK);
        }



        public virtual void DoMonsterSkill(string monsterName, string monsterSkillName, int monsterBaseATK) 
        {
            Console.WriteLine("{0}은(는) {1}을 썼다! {2}의 데미지를 가했다!", monsterName, monsterSkillName, monsterBaseATK*2); 
        }

        

        public virtual void TakeMonsterDamage(string monsterName, int monsterBaseATK) 
        {
            Console.WriteLine("{0}은(는) 공격을 받았다! {1}의 데미지를 입었다!", monsterName, monsterBaseATK);
        }



        public virtual void FallMonster(string monsterName) 
        {
            Console.WriteLine("{0}의 체력은 0이다! {0}은 쓰러졌다", monsterName);
        }


    }
}
