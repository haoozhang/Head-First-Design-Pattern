package CompoundPattern.Factory;

import CompoundPattern.Quackable;

/**
 * Factory Pattern: manage creation of instance
 * 1. define abstract methods
 * 2. extend abstract class and construct specific instance
 */
public abstract class AbstractDuckFactory {

    public abstract Quackable createMallardDuck();

    public abstract Quackable createRedheadDuck();

    public abstract Quackable createDuckCall();

    public abstract Quackable createRubberDuck();

    public abstract Quackable createAdapterDuck();
}
