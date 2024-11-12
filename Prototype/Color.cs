namespace Prototype;

public class Color(ushort red, ushort green, ushort blue) : IPrototype
{

    public static Color LightGray => new(217, 217, 127);
    public IPrototype Clone() => new Color(red, green, blue);
}