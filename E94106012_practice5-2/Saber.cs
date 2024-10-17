using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E94106012_practice5_2
{
    class Saber : Servant
    {
        public Saber()
        {
            character = "Saber";
            hp = 101;
            charge = 0;
            attack = 3;
            speed = 1;
        }
        public void reset()
        {
            character = "Saber";
            hp = 101;
            charge = 0;
            attack = 3;
            speed = 1;
            skillCD = 1;
        }
        public override void Skill()
        {
            // 在這裡實作 Saber 的技能
            skillCD = 0;
            attack = attack*2;
            MessageBox.Show("Saber使用了技能", "", MessageBoxButtons.OK);
        }
    }
}
