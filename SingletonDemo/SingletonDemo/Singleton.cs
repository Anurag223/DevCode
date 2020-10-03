using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonDemo
{
    public class Singleton
    {
        private static int _counter = 0;
        private static Singleton singleinstance = null;
        private static readonly object lockobject = new object();
        private Singleton()
        {
            _counter++;
        }
        public static Singleton GetInstance()    //Thread Safe Singleton Pattern implementation
        {
            if (singleinstance == null)
            {
                lock (lockobject)
                {
                    if (singleinstance == null)
                    {
                        singleinstance = new Singleton();
                    }
                }
            }
            Console.WriteLine("Singleton Method:" + _counter);
            return singleinstance;
        }
    }
}
