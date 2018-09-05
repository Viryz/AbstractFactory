using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class SaverSingleton
    {
        private static SaverSingleton instance;

        private static int count;

        public SaverSingleton(int c)
        {
            count = c;
        }

        public static SaverSingleton GetInstance(int c)
        {
            if (instance == null)
                instance = new SaverSingleton(c);
            return instance;
        }

        public void SaveLog(string str)
        {
            using (StreamWriter fs = new StreamWriter("result" + count.ToString() + ".log"))
            {
                fs.WriteLine(str);
            }
        }

    }
}
