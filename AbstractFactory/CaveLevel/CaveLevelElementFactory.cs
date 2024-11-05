using AbstractFactory.Common;
namespace AbstractFactory.CaveLevel;

public class CaveLevelElementFactory : LevelElementFactory
{

    public override IEnemy CreateEnemy() => new Goblin();
    public override IWeapon CreateWeapon() => new Axe();
    public override IPowerUp CreatePowerUp() => new Cristal();
}