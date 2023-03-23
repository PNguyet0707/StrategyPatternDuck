using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuck.QuackBehavior
{
    public class Queack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Queack queack !");
        }
    }
}
