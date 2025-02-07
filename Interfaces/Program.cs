using System;

namespace Interfaces
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IRun MyRunningCat = new Cat();

            IWalk WalkingCat = new Cat();

            IWalk MyWalkingHuman = new Human();

            IRun MyRunningHuman = new Human();
            Run(MyRunningCat);
            Run(MyRunningHuman);
            Walk(MyWalkingHuman);
        }

        private static void Walk(IWalk walker)
        {
            walker.Walk();
        }

        private static void Run(IRun runner)
        {
            runner.Run();
        }
    }
}