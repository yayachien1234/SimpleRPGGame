using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E94106012_practice5_2
{
    class Caster : Servant
    {
        public Caster()
        {
            character = "Caster";
            hp = 100;
            charge = 0;
            attack = 2;
            speed = 2;
        }
        public void reset()
        {
            character = "Caster";
            hp = 100;
            charge = 0;
            attack = 2;
            speed = 2;
            skillCD = 1;
        }
        public override void Skill()
        {
            // 在這裡實作 Caster 的技能
            skillCD = 0;
            hp = hp + hp/2;
            MessageBox.Show("Caster使用了技能", "", MessageBoxButtons.OK);
        }
    }
}
