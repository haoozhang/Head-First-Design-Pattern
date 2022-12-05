
using SimUDuck.Ducks;
using SimUDuck.QuackBehavior;

// Strategy Pattern

Duck redHeadDuck = new ReadHeadDuck();
redHeadDuck.PerformFly();
redHeadDuck.PerformQuack();
redHeadDuck.Display();
            
redHeadDuck.QuackBehavior = new Squeak();
            
redHeadDuck.PerformQuack();