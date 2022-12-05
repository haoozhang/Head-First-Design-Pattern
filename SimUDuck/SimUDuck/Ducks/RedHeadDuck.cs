using SimUDuck.FlyBehavior;
using SimUDuck.QuackBehavior;

namespace SimUDuck.Ducks;

public class ReadHeadDuck : Duck
{
    public ReadHeadDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new Quack();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm red head duck!");
    }
}