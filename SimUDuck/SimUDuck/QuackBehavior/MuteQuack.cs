namespace SimUDuck.QuackBehavior;

public class MuteQuack : IQuackBehavior
{
    public void QuackSound()
    {
        Console.WriteLine("mute quack!");
    }
}