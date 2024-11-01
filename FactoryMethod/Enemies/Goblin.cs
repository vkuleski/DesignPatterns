
namespace FactoryMethod.Enemies;

public class Goblin : IEnemy
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