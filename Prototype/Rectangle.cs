namespace Prototype;

public class Rectangle(int width, int height, Color color) : IShape
{
    public IPrototype Clone()
    {
        return new Rectangle(width, height, color);
    }
}