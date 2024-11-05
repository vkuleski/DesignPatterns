// See https://aka.ms/new-console-template for more information

using Builder;

var pizza = Pizza.Builder.Start()
    .SetDough(dough=>dough
        .SetThickness(3)
        .SetFlour("whole wheat")
        .Build())
    .SetSauce("Spicy tomato sauce")
    .SetCheese("Vegan cheese")
    .AddTopping("Olives")
    .AddTopping("Onions")
    .Build();

Console.WriteLine(pizza);