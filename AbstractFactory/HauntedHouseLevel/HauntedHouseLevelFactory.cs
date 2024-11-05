using AbstractFactory.Common;
namespace AbstractFactory.HauntedHouseLevel;

public class HauntedHouseLevelFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy() => new Ghost();
    public override IWeapon CreateWeapon() => new Staff();
    public override IPowerUp CreatePowerUp() => new Orb();
}