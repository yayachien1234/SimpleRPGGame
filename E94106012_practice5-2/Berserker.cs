using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E94106012_practice5_2
{
    class Berserker : Servant
    {
        public Berserker()
        {
            character = "Berserker";
            hp = 100;
            charge = 0;
            attack = 4;
            speed = 4;
        }
        public void reset()
        {
            character = "Berserker";
            hp = 100;
            charge = 0;
            attack = 4;
            speed = 4;
            skillCD = 1;
        }
        public override void Skill()
        {
            // 在這裡實作 Berserker 的技能
            skillCD = 0;
            attack = attack * 2;
            hp = hp - hp / 2;
            MessageBox.Show("Berserker使用了技能", "", MessageBoxButtons.OK);
        }
    }
}
