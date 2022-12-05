using SimUDuck.FlyBehavior;
using SimUDuck.QuackBehavior;

namespace SimUDuck.Ducks;

public abstract class Duck
{
    public IFlyBehavior FlyBehavior { get; set; }
    public IQuackBehavior QuackBehavior { get; set; }

    public abstract void Display();

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void PerformQuack()
    {
        QuackBehavior.QuackSound();
    }
}