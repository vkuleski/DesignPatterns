using FactoryMethod.Enemies;
namespace FactoryMethod.Levels;

public class HuntedCaveLevel : Level
{
    public override IEnemy CreateEnemy() => new Ghost();
}