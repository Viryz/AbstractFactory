using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MagicType3 : Magic
    {
        public override void UseMagic(AbstractHero hero)
        {
            hero.GetDamage(2);
            Console.WriteLine("Make damage");
        }

        public override string ToString()
        {
            return "magic: damage\n";
        }
    }
}
