using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AbstractHero
    {
        private Magic magic;
        private Hit hit;
        private SpecialSkill skill;

        public Magic Magic { get { return magic; } }
        public Hit Hit { get { return hit; } }
        public SpecialSkill SpecialSkill { get { return skill; } }

        public AbstractHero(AbstractHeroFactory factory)
        {
            magic = factory.CreateMagic();
            hit = factory.CreateHit();
            skill = factory.CreateSpecialSkill();
        }
    }
}
