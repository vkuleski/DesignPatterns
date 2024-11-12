namespace Prototype;

internal record Person(string FirstName, List<string> Hobbies)
{
    
    public static Person Create() => new("John", new() { "Skiing", "Hiking" }); 
    public Person ShallowClone()
    {
        return this with
        {
        };
    }
    public Person DeepClone()
    {
        return new(FirstName, [..Hobbies]);
    }
}