// See https://aka.ms/new-console-template for more information

using Dumpify;
using Prototype;
Console.WriteLine("Hello, World!");


var person = Person.Create();

var shallowCopy = person.ShallowClone();
var deepCopy = person.DeepClone();

shallowCopy.Hobbies.Add("Reading");
deepCopy.Hobbies.Add("Biking");

person.Dump();

// canvas
var rectangle = new Rectangle(width: 100, height: 100, Color.LightGray);
return;

void CopyDrag(IShape shape)
{
    var newShape = shape.Clone();

    const bool iSMouseDown = true;
    while (iSMouseDown)
    {
        //draw new shape to current location
    }
}