// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.Builders;
// var builder = new SimpleProductBuilder();
var builder = new ComplexProductBuilder();
var productDirector = new ProductDirector(builder);

productDirector.ConstructProduct();
var product = builder.Build();

Console.WriteLine(product);
