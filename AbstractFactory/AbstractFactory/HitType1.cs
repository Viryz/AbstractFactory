using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HitType1 : Hit
    {
        public override void UseHit(AbstractHero hero)
        {
            hero.GetDamage(1);
            Console.WriteLine("Short distance hit");
        }

        public override string ToString()
        {
            return "hit: short\n";
        }
    }
}
