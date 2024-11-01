using FactoryMethod.Enemies;
namespace FactoryMethod.Levels;

public class CaveLevel : Level
{

    public override IEnemy CreateEnemy() => new Goblin();
}