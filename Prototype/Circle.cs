namespace Prototype;

public class Circle(int radius, Color color) : IShape
{
    public IPrototype Clone()
    {
        return new Circle(radius, color.Clone());
    }
}