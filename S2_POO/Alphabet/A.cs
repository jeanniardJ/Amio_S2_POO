using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_POO.Alphabet
{
    public interface A
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

        public abstract void Methode1();

        public virtual void Methode2() { }

        public void Methode3 () { 
        }

        protected void Methode4() { 
        }

        private void Methode5()
        {

        }
    }
}
