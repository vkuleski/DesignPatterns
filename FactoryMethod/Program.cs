using FactoryMethod.Creators;
using FactoryMethod.Levels;
using FactoryMethod.Products;

//using factory method design pattern
Creator creator = new ConcreteCreator();
IProduct product = creator.CreateProduct();

Level level1 = LevelFactory.CreateLevel(levelNumber: 1);
level1.EncounterEnemy();

Level level2 = LevelFactory.CreateLevel(levelNumber: 2);
level2.EncounterEnemy();

//without using factory method design pattern
ConcreteCreator concreteCreator = new ConcreteCreator();
var product1 = concreteCreator.CreateProduct();