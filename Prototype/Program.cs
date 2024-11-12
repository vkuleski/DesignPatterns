// See https://aka.ms/new-console-template for more information

using Dumpify;
Console.WriteLine("Hello, World!");


var person = new Person("John", ["Skiing", "Hiking"]);
// var shallowCopy = new Person("Jane", ["Swimming", "Running"]);

var shallowCopy = person.ShallowClone();
var deepCopy = person.DeepClone();

shallowCopy.Hobbies.Add("Reading");
deepCopy.Hobbies.Add("Biking");

person.Dump();
internal record Person(string FirstName, List<string> Hobbies)
{
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