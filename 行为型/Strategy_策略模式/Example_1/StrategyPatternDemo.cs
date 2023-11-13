using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_策略模式.Example_1
{
    public class StrategyPatternDemo
    {
        public static void test()
        {

            /*
            策略模式
            */
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationSubstract());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));


            /*
            策略模式 + 简单工厂模式
            */
            // Context context = new Context("+");
            // Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

            // context = new Context("-");
            // Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            // context = new Context("*");
            // Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
        }
    }
}
