using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SpecialSkillType1 : SpecialSkill
    {
        public override void UsePsecialSkill()
        {
            Console.WriteLine("Dodge");
        }

        public override string ToString()
        {
            return "special skill: dodge\n";
        }
    }
}
