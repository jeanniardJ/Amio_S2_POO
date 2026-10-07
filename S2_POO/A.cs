using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO
{
    public class A
    {
        private static int x = 10;
        static int y = 20;
        public void Print()
        {
            Console.WriteLine(x);
        }

        public static void test()
        {
            Console.WriteLine(y);
        }
    }
}
