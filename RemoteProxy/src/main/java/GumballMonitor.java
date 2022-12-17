import java.rmi.RemoteException;

public class GumballMonitor {
    GumballMachineRemote Machine;

    public GumballMonitor(GumballMachineRemote machine) {
        Machine = machine;
    }

    public void Report() {
        try {
            System.out.println("Gumball Machine: " + Machine.getLocation());
            System.out.println("Current Inventory: " + Machine.getCount());
            System.out.println("Current State: " + Machine.getCurrentState());
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }
}
