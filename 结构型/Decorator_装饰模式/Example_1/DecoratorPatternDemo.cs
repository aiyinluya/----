using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_装饰模式.Example_1
{
   public class DecoratorPatternDemo
    {
        public static void test() {

            IShape circle = new Circle();
            circle.Draw();
            ShapeDecorator_图形装饰抽象类 redCircle = new RedShapeDecorator(circle);
            ShapeDecorator_图形装饰抽象类 shapeDecorator = new RedShapeDecorator(new Rectangle());

            ShapeDecorator_图形装饰抽象类 yellowCircle = new YellowShapeDecorator(circle);

            circle.Draw();
            ((RedShapeDecorator)redCircle).Draw();
            shapeDecorator.Draw();
            ((YellowShapeDecorator)yellowCircle).Draw();
        }
    }
}
