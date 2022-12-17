package CompoundPattern.Composition;

import CompoundPattern.Observer.Observer;
import CompoundPattern.Quackable;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/**
 * Iterator Pattern: encapsulate iteration and hide collection implementation
 * Composition Pattern:
 */
public class Flock implements Quackable {

    private List<Quackable> quackers;

    public Flock() {
        quackers = new ArrayList<>();
    }

    public void add(Quackable quackable) {
        quackers.add(quackable);
    }

    @Override
    public void quack() {
        Iterator<Quackable> iterator = quackers.iterator();
        while (iterator.hasNext()) {
            Quackable quackable = iterator.next();
            // quack() will notify observers for each instance here, so no need to implement later
            quackable.quack();
        }
    }

    @Override
    public void registerObserver(Observer observer) {
        Iterator<Quackable> iterator = quackers.iterator();
        while (iterator.hasNext()) {
            Quackable quackable = iterator.next();
            quackable.registerObserver(observer);
        }
    }

    @Override
    public void notifyObservers() {

    }
}
