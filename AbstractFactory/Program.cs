// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;
using AbstractFactory.Products;


UsingAbstractFactoryPattern();
return;

void UsingAbstractFactoryPattern()
{

    var abstractFactory = new ConcreteFactory();
    var product1 = abstractFactory.CreateProduct1();
    var product2 = abstractFactory.CreateProduct2();
}

void NotUsingAbstractFactoryPattern()
{
    ConcreteProduct1 product1 = new();
    ConcreteProduct2 product2 = new();
}
    

