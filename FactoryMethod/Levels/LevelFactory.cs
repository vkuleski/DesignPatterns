namespace FactoryMethod.Levels;

// simple factory for creating level
public static class LevelFactory
{
    public static Level CreateLevel(int levelNumber) => levelNumber switch
    {
        1 => new CaveLevel(),
        2 => new CaveLevel(),
        _ => throw new Exception("Invalid level number")
    };
}