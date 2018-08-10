using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class HitType2 : Hit
    {
        public override void UseHit()
        {
            Console.WriteLine("Long distance hit");
        }
    }
}
