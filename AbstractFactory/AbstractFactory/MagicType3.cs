using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class MagicType3 : Magic
    {
        public override void UseMagic()
        {
            Console.WriteLine("Make damage");
        }
    }
}
