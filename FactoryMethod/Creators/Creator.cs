using FactoryMethod.Products;
namespace FactoryMethod.Creators;

public abstract class Creator
{
    public abstract IProduct CreateProduct();
}