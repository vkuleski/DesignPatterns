using AbstractFactory.Products;

namespace AbstractFactory.Factories;

public class ConcreteFactory : AbstractFactory
{
    public override IProduct1 CreateProduct1() => new ConcreteProduct1();
    public override IProduct2 CreateProduct2() => new ConcreteProduct2();
}