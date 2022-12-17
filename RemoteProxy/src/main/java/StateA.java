public class StateA implements State {

    // transient: don't serialize this property
    private transient Context Context;

    public StateA(Context context) {
        Context = context;
    }

    @Override
    public void transitsA2B() {
        System.out.println("A to B");
        Context.setCurrentState(Context.getStateB());
    }

    @Override
    public void transitsB2A() {
        System.out.println("already A");
    }
}
