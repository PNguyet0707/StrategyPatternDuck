using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    internal abstract class Duck
    {
        protected IFlyBehavior  flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck() { }

        public void SetFlyBehavior(IFlyBehavior FlyBehavior)
        {
            flyBehavior = FlyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior QuackBehavior)
        {
            quackBehavior = QuackBehavior;
        }

        public abstract void Display();
        public void PerformFly ()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
            

    }
}
