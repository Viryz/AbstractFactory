using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class AbstractHeroFactory
    {
        public abstract Magic CreateMagic();
        public abstract Hit CreateHit();
        public abstract SpecialSkill CreateSpecialSkill();
    }
}
