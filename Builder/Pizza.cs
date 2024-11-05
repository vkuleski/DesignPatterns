namespace Builder;

public record Pizza(
    Dough Dough,
    string Sauce,
    string Cheese,
    List<string> Toppings)
{
    public class Builder : IDoughStep, ISouseStep, ICheeseStep, IToppingStep
    {
        private Dough _dough = default!;
        private string _sauce = string.Empty;
        private string _cheese = string.Empty;
        private List<string> _toppings = [];
        
        private Builder() { }
        public static IDoughStep Start() => new Builder();
        public ISouseStep SetDough(Action<Dough.Builder> action)
        {
            var builder = new Dough.Builder();
            action(builder);
            _dough = builder.Build();
            
            return this;
        }
        public ICheeseStep SetSauce(string sauce)
        {
            _sauce = sauce;
            return this;
        }
        public IToppingStep SetCheese(string cheese)
        {
            _cheese = cheese;
            return this;
        }
        public IToppingStep AddTopping(string toppings)
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

    public interface IDoughStep
    {
        ISouseStep SetDough(Action<Dough.Builder> action);
    }

    public interface ISouseStep
    {
        ICheeseStep SetSauce(string sauce);
    }

    public interface ICheeseStep
    {
        IToppingStep SetCheese(string cheese);
    }

    public interface IToppingStep
    {
        IToppingStep AddTopping(string topping);
        Pizza Build();
    }
}