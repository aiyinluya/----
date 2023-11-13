using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_装饰模式.Example_1
{
    class YellowShapeDecorator : ShapeDecorator_图形装饰抽象类
    {

        public YellowShapeDecorator(IShape decoratedShape) : base(decoratedShape) { }

        public new void Draw()
        { 
            this.Draw(ConsoleColor.Yellow);
            setRedBorder(decoratedShape); 
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Yellow");
        }
    }
}
