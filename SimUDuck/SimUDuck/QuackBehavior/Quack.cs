namespace SimUDuck.QuackBehavior;

public class Quack : IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("quack!");
    }
}