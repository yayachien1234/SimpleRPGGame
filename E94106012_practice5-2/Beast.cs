using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E94106012_practice5_2
{
    class Beast : Servant
    {
        public Beast()
        {
            character = "Beast";
            hp = 500;
            charge = 0;
            attack = 2;
            speed = 3;
            skillCD = 1;
        }
        public void reset()
        {
            character = "Beast";
            hp = 500;
            charge = 0;
            attack = 2;
            speed = 3;
        }

        public override void Skill()
        {
            // 在這裡實作 Beast 的技能
            skillCD = 0;
            attack += 2;
        }
    }
}
