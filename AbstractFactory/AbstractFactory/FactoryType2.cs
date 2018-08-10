using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryType2 : AbstractHeroFactory
    {
        public override Hit CreateHit()
        {
            return new HitType2();
        }

        public override Magic CreateMagic()
        {
            return new MagicType3();
        }

        public override SpecialSkill CreateSpecialSkill()
        {
            return new SpecialSkillType1();
        }
    }
}
