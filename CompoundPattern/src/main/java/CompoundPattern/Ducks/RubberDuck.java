package CompoundPattern.Ducks;

import CompoundPattern.Observer.Observable;
import CompoundPattern.Observer.Observer;
import CompoundPattern.Quackable;

public class RubberDuck implements Quackable {

    private Observable observable;

    public RubberDuck() {
        observable = new Observable(this);
    }

    @Override
    public void quack() {
        System.out.println("squeak!");
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
