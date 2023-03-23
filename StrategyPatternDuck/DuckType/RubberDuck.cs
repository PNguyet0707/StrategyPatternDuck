using StrategyPatternDuck.FlyBehavior;
using StrategyPatternDuck.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuck.DuckType
{
    internal class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Hello I'm rubber duck");
        }

        public RubberDuck()
        {
            flyBehavior = new FLyNoWay();
            quackBehavior = new MuteQuack();
        }
    }
}
