using StrategyPatternDuck.DuckType;
using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;

namespace StrategyPatternDuck
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Duck rubber = new RubberDuck();
            Console.WriteLine("Before set behavior");
            rubber.Display();
            rubber.Swim();
            rubber.PerformQuack();
            rubber.PerformFly();
            Console.WriteLine();
            Console.WriteLine("After set behavior");
            rubber.SetFlyBehavior(new FLyWithWings());
            rubber.SetQuackBehavior(new Queack());
            rubber.PerformQuack();
            rubber.PerformFly();

        }


    }
}