package CompoundPattern.Decorator;

import CompoundPattern.Observer.Observable;
import CompoundPattern.Observer.Observer;
import CompoundPattern.Quackable;

/**
 * Decorator Pattern: add responsibility
 * 1. implement the same interface
 * 2. reference the instance to be decorated
 * 3. in override method, call decorated instance's method, and add own logic
 */
public class QuackCounter implements Quackable {

    private final Quackable duck;

    private static int numberOfQuack;

    public QuackCounter(Quackable duck) {
        this.duck = duck;
        numberOfQuack = 0;
    }

    @Override
    public void quack() {
        duck.quack();
        numberOfQuack++;
    }

    public static int getNumberOfQuack() {
        return numberOfQuack;
    }

    @Override
    public void registerObserver(Observer observer) {
        duck.registerObserver(observer);
    }

    @Override
    public void notifyObservers() {
        duck.notifyObservers();
    }
}
