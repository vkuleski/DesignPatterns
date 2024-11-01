using FactoryMethod.Products;
namespace FactoryMethod.Creators;

public class ConcreteCreator : Creator
{

    public override IProduct CreateProduct() => new ConcreteProduct();
}