public class StateB implements State {

    // transient: don't serialize this property
    private transient Context Context;

    public StateB(Context context) {
        Context = context;
    }

    @Override
    public void transitsA2B() {
        System.out.println("already B");
    }

    @Override
    public void transitsB2A() {
        System.out.println("B to A");
        Context.setCurrentState(Context.getStateA());
    }
}
