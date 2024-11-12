namespace Builder.Builders;

public class ComplexProductBuilder : IBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;
    
    public void BuildName()
    {
        _name = "Complex product";
    }
    public void BuildDescription()
    {
        _description = "This is a complex product";
    }
    
    public Product Build() => new Product(Name: _name, Description: _description);
}
