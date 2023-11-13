using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_策略模式.Example_1
{
    public class Context
    {
        private IStrategy strategy;

        /*
            策略模式
        */
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        /*
            策略模式 + 简单工厂模式
        */
        // public Context(string type)
        // {
        //     switch (type)
        //     {
        //         case "+": this.strategy = new OperationAdd(); break;
        //         case "-": this.strategy = new OperationSubstract(); break;
        //         case "*": this.strategy = new OperationMultiply(); break;
        //         default: break;
        //     }
        // }

        public int ExecuteStrategy(int num1, int num2)
        {
            return strategy.DoOperation(num1, num2);
        }
    }
}
