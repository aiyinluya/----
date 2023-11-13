using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂方法模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    public abstract class ShapeFactory_图形工厂
    {
        public abstract Shape_图形接口 GetShape();
    }
}
