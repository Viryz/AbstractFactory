using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MagicType2 : Magic
    {
        public override void UseMagic(AbstractHero hero)
        {
            hero.GetDamage(-2);
            Console.WriteLine("Regen health");
        }

        public override string ToString()
        {
            return "magic: regen health\n";
        }
    }
}
