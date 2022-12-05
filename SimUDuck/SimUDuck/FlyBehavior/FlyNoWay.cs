namespace SimUDuck.FlyBehavior;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("fly no way!");
    }
}