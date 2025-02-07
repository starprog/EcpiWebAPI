using System;

namespace Interfaces
{
    public class Cat : IWalk, IRun
    {
        public void Run()
        {
            Console.WriteLine("Human is running");
        }

        public void Walk()
        {
            Console.WriteLine("Human is walking");
        }
    }
}