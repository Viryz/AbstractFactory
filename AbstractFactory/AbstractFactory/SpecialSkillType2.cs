﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SpecialSkillType2 : SpecialSkill
    {
        public override void UsePsecialSkill()
        {
            Console.WriteLine("Counterattack");
        }

        public override string ToString()
        {
            return "special skill: counterattack\n";
        }
    }
}
