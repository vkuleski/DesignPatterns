namespace FactoryMethod.Enemies;

public class Ghost : IEnemy
{
    public void Scream()
    {
        Console.WriteLine("Scream Attack!");
    }
    public void Attack()
    {
        Console.WriteLine("Ghost Attack!");
    }
}