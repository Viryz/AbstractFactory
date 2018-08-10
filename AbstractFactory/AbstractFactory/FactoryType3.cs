using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryType3 : AbstractHeroFactory
    {
        public override Hit CreateHit()
        {
            return new HitType2();
        }

        public override Magic CreateMagic()
        {
            return new MagicType2();
        }

        public override SpecialSkill CreateSpecialSkill()
        {
            return new SpecialSkillType1();
        }
    }
}
