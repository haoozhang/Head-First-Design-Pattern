package CompoundPattern.Observer;

public class QuackOlogist implements Observer {

    @Override
    public void update(QuackObservable duck) {
        System.out.println("QuackOlogist: " + duck + "just quacked.");
    }
}
