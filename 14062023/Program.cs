using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14062023
{
    interface Ia
    {
        string Ia(int n);
    }
    interface Ib
    {
        string Ib(int n);
        void b2();

    }
    interface Ic :Ia,Ib
    {
        void c2(int n);

    }
    class In : Ic
    {
        public void b2()
        {
            throw new NotImplementedException();
        }

        public void c2(int n)
        {
            throw new NotImplementedException();
        }

        public string Ia(int n)
        {
            throw new NotImplementedException();
        }

        public string Ib(int n)
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            In a = new In();
            Ia i = new In();
            


            //стандартные интерфейсы 

        }

    }
}
