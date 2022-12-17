package CompoundPattern.Ducks;

import CompoundPattern.Observer.Observable;
import CompoundPattern.Observer.Observer;
import CompoundPattern.Quackable;

public class DuckCall implements Quackable {

    private Observable observable;

    public DuckCall() {
        observable = new Observable(this);
    }

    @Override
    public void quack() {
        System.out.println("kayak!");
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
