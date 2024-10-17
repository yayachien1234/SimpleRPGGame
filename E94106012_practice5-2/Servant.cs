using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E94106012_practice5_2
{
    class Servant
    {
        public string? character;
        public int hp;
        public int attack;
        public int speed;
        public int charge;
        public int skillCD = 1;
        public virtual void Skill(){ }
        
        public String? GetCharacter()
        {
            return character;
        }
        public void Injured(int injuredPoing)
        {
            hp -= injuredPoing;
        }
        public int GetHp() 
        { 
            return hp;
        }
        public int GetAttack()
        {
            return attack;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public int GetCharge()
        {
            return charge;
        }


    }
}
