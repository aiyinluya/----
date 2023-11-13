using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂方法模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    public class FactoryPatternDemo
    {
        public static void test()
        {
            ShapeFactory_图形工厂 shapeFactory = new ShapeFactory_圆形工厂();
            shapeFactory.GetShape().Draw();

            ShapeFactory_图形工厂 shapeFactory1 = new ShapeFactory_正方形工厂();
            shapeFactory1.GetShape().Draw();
            
        }
    }
}

