// See https://aka.ms/new-console-template for more information

using Builder;

var pizza = new Pizza.Builder()
    .SetDough(dough=>dough
        .SetThickness(3)
        .SetFlour("whole wheat")
        .Build())
    .SetSauce("Spicy tomato sauce")
    .SetCheese("Vegan cheese")
    .AddToppings("Olives")
    .AddToppings("Onions")
    .Build();

Console.WriteLine(pizza);