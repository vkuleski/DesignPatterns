// See https://aka.ms/new-console-template for more information

using Builder;
using Builder.Builders;

var product = new Product.Builder()
    .SetName("Simple Product")
    .SetDescription("Simple description")
    .Build();

Console.WriteLine(product);
