namespace Builder;

public record Pizza(
    Dough Dough,
    string Sauce,
    string Cheese,
    List<string> Toppings)
{
    public class Builder
    {
        private Dough _dough = default!;
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private List<string> _toppings = [];

        
        public Builder SetDough(Action<Dough.Builder> action)
        {
            var builder = new Dough.Builder();
            action(builder);
            _dough = builder.Build();
            
            return this;
        }
        public Builder SetSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }
        public Builder SetCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }
        public Builder AddToppings(string toppings)
        {
            _toppings.Add(toppings);
            return this;
        }

        public Pizza Build() => new Pizza(
            _dough,
            _sauce, 
            _cheese,
            _toppings);
    }
}