namespace FactoryMethod.intro;


internal class PasswordFactory2
{
    public static IPassword Generate(ushort lenght) => lenght > 5 
        ? new SimplePassword() 
        : new ComplexPassword();
}

internal interface IPassword
{
}

internal class SimplePassword : IPassword;

internal class ComplexPassword : IPassword;

//A concrete class that creates a concrete class
internal class PasswordFactory
{
    public static Password Generate(/*...*/) =>  Password.Generate(); //complex logic
}

//A static factory method - a static method defined in concrete type, that create that type
internal class Password
{
    private Password()
    {   
    }
    
    public static Password Generate(/*...*/) =>  new Password();
}