// See https://aka.ms/new-console-template for more information

using AbstractFactory.CaveLevel;
using AbstractFactory.Common;
using AbstractFactory.HauntedHouseLevel;
Console.WriteLine("Hello World!");

SetupEnvironment(new CaveLevelElementFactory());
SetupEnvironment(new HauntedHouseLevelFactory());
return;

void SetupEnvironment(LevelElementFactory factory)
{
    var enemy = factory.CreateEnemy();
    var weapon = factory.CreateWeapon();
    var powerUp = factory.CreatePowerUp();
    
    //..
}

