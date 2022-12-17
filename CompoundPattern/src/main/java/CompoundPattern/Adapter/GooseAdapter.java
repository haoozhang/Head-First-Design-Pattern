package CompoundPattern.Adapter;

import CompoundPattern.Observer.Observable;
import CompoundPattern.Observer.Observer;
import CompoundPattern.Quackable;

/**
 * Adapter Pattern: aims to interface transformation
 * 1. implement target interface
 * 2. reference the instance to be adapt
 * 3. in override method, call adapt instance's method
 */
public class GooseAdapter implements Quackable {

    private Observable observable;

    private final Goose goose;

    public GooseAdapter(Goose goose) {
        this.goose = goose;
        observable = new Observable(this);
    }

    @Override
    public void quack() {
        goose.honk();
        notifyObservers();
    }

    @Override
    public void registerObserver(Observer observer) {
        observable.registerObserver(observer);
    }

    @Override
    public void notifyObservers() {
        observable.notifyObservers();
    }
}
