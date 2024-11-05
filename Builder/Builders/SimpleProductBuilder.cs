namespace Builder.Builders;

public class SimpleProductBuilder : IBuilder
{
    private string _name = string.Empty;
    private string _description = string.Empty;
    
    public void BuildName()
    {
        _name = "Simple product";
    }
    public void BuildDescription()
    {
        _description = "This is a simple product";
    }
    public Product Build() => new Product(Name: _name, Description: _description);
    
}