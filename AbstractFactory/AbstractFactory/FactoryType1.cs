using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryType1 : AbstractHeroFactory
    {
        public override Hit CreateHit()
        {
            return new HitType1();
        }

        public override Magic CreateMagic()
        {
            return new MagicType1();
        }

        public override SpecialSkill CreateSpecialSkill()
        {
            return new SpecialSkillType2();
        }
    }
}
