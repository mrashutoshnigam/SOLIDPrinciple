using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    class Singleton
    {
        private static Singleton singleTon;
        private Singleton()
        {
            
        }
        public Singleton(int a)
        {

        }
        public static Singleton GetInstance()
        {
            if (singleTon != null)
                return singleTon;
            else
                return new Singleton();
        }
        public override string ToString()
        {
            return "Singleton Pattern";
        }
    }
}
