using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Human : IWalk, IRun
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