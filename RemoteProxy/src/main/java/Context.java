import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class Context extends UnicastRemoteObject implements GumballMachineRemote {

    // all internal states
    private StateA StateA;

    private StateB StateB;

    // current state
    private State CurrentState;

    private int Count;

    private String Location;

    public Context(int count, String location) throws RemoteException {
        StateA = new StateA(this);
        StateB = new StateB(this);

        Count = count;
        Location = location;
        CurrentState = StateA;
    }

    public StateA getStateA() {
        return StateA;
    }

    public StateB getStateB() {
        return StateB;
    }

    public void setCurrentState(State currentState) {
        CurrentState = currentState;
    }

    @Override
    public State getCurrentState() {
        return CurrentState;
    }

    @Override
    public int getCount() throws RemoteException {
        return Count;
    }

    @Override
    public String getLocation() throws RemoteException {
        return Location;
    }
}
