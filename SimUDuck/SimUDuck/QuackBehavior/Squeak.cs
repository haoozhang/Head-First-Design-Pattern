namespace SimUDuck.QuackBehavior;

public class Squeak : IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("squeak!");
    }
}