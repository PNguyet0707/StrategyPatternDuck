using StrategyPatternDuck.DuckType;

namespace StrategyPatternDuck
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Duck duck1 = new MallarDuck();
           duck1.Display();
           duck1.PerformQuack();
           duck1.PerformFly();
           duck1.Swim();

        }

        
    }
}