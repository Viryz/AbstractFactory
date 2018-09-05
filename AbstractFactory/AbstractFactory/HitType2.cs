using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HitType2 : Hit
    {
        public override void UseHit(AbstractHero hero)
        {
            Random rnd = new Random();
            if (rnd.Next(0, 1) == 0)
                hero.GetDamage(2);
            else hero.GetDamage(1);
            Console.WriteLine("Long distance hit");
        }

        public override string ToString()
        {
            return "hit: long\n";
        }
    }
}
