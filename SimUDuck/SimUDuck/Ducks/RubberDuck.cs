using SimUDuck.FlyBehavior;
using SimUDuck.QuackBehavior;

namespace SimUDuck.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new MuteQuack();
    }
    
    public override void Display()
    {
        Console.WriteLine("I'm rubber duck!");
    }
}