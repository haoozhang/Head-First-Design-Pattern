namespace AdapterPattern.Ducks;

public class MallarDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!");
    }

    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}