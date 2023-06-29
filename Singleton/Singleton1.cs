using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton1
    {
        private static readonly Lazy<Singleton1> lazy =
        new Lazy<Singleton1>(() => new Singleton1());

        public static Singleton1 Instance { get { return lazy.Value; } }

        private Singleton1()
        {
            // Private constructor to prevent external instantiation
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing something...");
        }
    }
}
