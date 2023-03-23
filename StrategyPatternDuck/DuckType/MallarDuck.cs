using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck.DuckType
{
    internal class MallarDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a mallar duck");
        }

        public MallarDuck()
        {
            flyBehavior = new FLyWithWings();
            quackBehavior = new Quack();
        }
    }
}
