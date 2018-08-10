using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MagicType2 : Magic
    {
        public override void UseMagic()
        {
            Console.WriteLine("Regen health");
        }
    }
}
