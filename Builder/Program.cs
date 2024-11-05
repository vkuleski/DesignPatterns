// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.Builders;

Product.Builder builder = new();
builder.BuildName("Simple Product");
builder.BuildDescription("Simple description");
var product = builder.Build();

Console.WriteLine(product);
