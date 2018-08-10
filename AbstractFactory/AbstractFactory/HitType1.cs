using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HitType1 : Hit
    {
        public override void UseHit()
        {
            Console.WriteLine("Short distance hit");
        }
    }
}
