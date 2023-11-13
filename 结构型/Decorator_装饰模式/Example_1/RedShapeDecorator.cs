using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_装饰模式.Example_1
{
    class RedShapeDecorator : ShapeDecorator_图形装饰抽象类
    {

        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public void Draw()
        { 
            
            this.Draw(ConsoleColor.Red);
            setRedBorder(decoratedShape); 
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
