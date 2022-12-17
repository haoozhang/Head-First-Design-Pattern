package CompoundPattern;

import CompoundPattern.Adapter.Goose;
import CompoundPattern.Adapter.GooseAdapter;
import CompoundPattern.Composition.Flock;
import CompoundPattern.Decorator.QuackCounter;
import CompoundPattern.Ducks.DuckCall;
import CompoundPattern.Ducks.MallardDuck;
import CompoundPattern.Ducks.ReadheadDuck;
import CompoundPattern.Ducks.RubberDuck;
import CompoundPattern.Factory.AbstractDuckFactory;
import CompoundPattern.Factory.CountingDuckFactory;
import CompoundPattern.Observer.QuackOlogist;

public class DuckSimulator {

    public static void main(String[] args) {
        DuckSimulator simulator = new DuckSimulator();
        AbstractDuckFactory duckFactory = new CountingDuckFactory();

        simulator.simulate(duckFactory);
    }

    public void simulate(AbstractDuckFactory factory) {
        Quackable mallardDuck = factory.createMallardDuck();
        Quackable redheadDuck = factory.createRedheadDuck();
        Quackable duckCall = factory.createDuckCall();
        Quackable rubberDuck = factory.createRubberDuck();
        Quackable gooseAdapter = factory.createAdapterDuck();

        System.out.println("==== Duck Simulator ====");

        Flock flock = new Flock();

        flock.add(mallardDuck);
        flock.add(redheadDuck);
        flock.add(duckCall);
        flock.add(rubberDuck);
        flock.add(gooseAdapter);

        Flock flockOfMallards = new Flock();

        Quackable mallardOne = factory.createMallardDuck();
        Quackable mallardTwo = factory.createMallardDuck();
        Quackable mallardThree = factory.createMallardDuck();

        flockOfMallards.add(mallardOne);
        flockOfMallards.add(mallardTwo);
        flockOfMallards.add(mallardThree);

        flock.add(flockOfMallards);

        System.out.println("==== Duck Simulator (Whole Flock) ====");
        simulate(flock);

        System.out.println("==== Duck Simulator (Mallard Flock) ====");

        System.out.println("==== Duck Simulator (Observer) ====");
        QuackOlogist quackOlogist = new QuackOlogist();
        flockOfMallards.registerObserver(quackOlogist);

        simulate(flockOfMallards);

        System.out.println("The ducks quacked " + QuackCounter.getNumberOfQuack() + " times");
    }

    public void simulate(Quackable duck) {
        duck.quack();
    }
}
