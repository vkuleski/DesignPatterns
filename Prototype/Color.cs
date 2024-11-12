namespace Prototype;

public class Color(ushort red, ushort green, ushort blue) : IPrototype<Color>
{

    public static Color LightGray => new(217, 217, 127);
    public Color Clone() => new Color(red, green, blue);
}