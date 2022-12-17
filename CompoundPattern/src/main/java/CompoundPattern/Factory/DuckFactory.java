package CompoundPattern.Factory;

import CompoundPattern.Adapter.Goose;
import CompoundPattern.Adapter.GooseAdapter;
import CompoundPattern.Ducks.DuckCall;
import CompoundPattern.Ducks.MallardDuck;
import CompoundPattern.Ducks.ReadheadDuck;
import CompoundPattern.Ducks.RubberDuck;
import CompoundPattern.Quackable;

public class DuckFactory extends AbstractDuckFactory {

    @Override
    public Quackable createMallardDuck() {
        return new MallardDuck();
    }

    @Override
    public Quackable createRedheadDuck() {
        return new ReadheadDuck();
    }

    @Override
    public Quackable createDuckCall() {
        return new DuckCall();
    }

    @Override
    public Quackable createRubberDuck() {
        return new RubberDuck();
    }

    @Override
    public Quackable createAdapterDuck() {
        return new GooseAdapter(new Goose());
    }
}
