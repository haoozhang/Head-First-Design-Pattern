package CompoundPattern;

import CompoundPattern.Observer.QuackObservable;

public interface Quackable extends QuackObservable {
    public void quack();
}
