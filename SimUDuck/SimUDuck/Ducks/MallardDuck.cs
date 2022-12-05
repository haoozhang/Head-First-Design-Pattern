using SimUDuck.FlyBehavior;
using SimUDuck.QuackBehavior;

namespace SimUDuck.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new Squeak();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm mallard duck!");
    }
}