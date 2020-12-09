

namespace _2.AbstractFactoryPattem
{
    public abstract class AbstractFactory
    {
        public abstract IShape GetShape(string type);
        public abstract IColor GetColor(string type);
    }
}
