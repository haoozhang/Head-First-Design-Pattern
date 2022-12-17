package CompoundPattern.Factory;

import CompoundPattern.Adapter.Goose;
import CompoundPattern.Adapter.GooseAdapter;
import CompoundPattern.Decorator.QuackCounter;
import CompoundPattern.Ducks.DuckCall;
import CompoundPattern.Ducks.MallardDuck;
import CompoundPattern.Ducks.ReadheadDuck;
import CompoundPattern.Ducks.RubberDuck;
import CompoundPattern.Quackable;

public class CountingDuckFactory extends AbstractDuckFactory {

    @Override
    public Quackable createMallardDuck() {
        return new QuackCounter(new MallardDuck());
    }

    @Override
    public Quackable createRedheadDuck() {
        return new QuackCounter(new ReadheadDuck());
    }

    @Override
    public Quackable createDuckCall() {
        return new QuackCounter(new DuckCall());
    }

    @Override
    public Quackable createRubberDuck() {
        return new QuackCounter(new RubberDuck());
    }

    @Override
    public Quackable createAdapterDuck() {
        return new QuackCounter(new GooseAdapter(new Goose()));
    }
}
