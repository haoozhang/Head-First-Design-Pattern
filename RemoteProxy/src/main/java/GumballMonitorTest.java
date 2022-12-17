import java.rmi.Naming;
import java.rmi.RemoteException;

public class GumballMonitorTest {

    public static void main(String[] args) {
        String[] locations = {
            "rmi://localhost:5001/sane",
            "rmi://localhost:5001/boulder",
        };

        GumballMonitor[] monitors = new GumballMonitor[locations.length];
        for (int i = 0; i < monitors.length; i++) {
            try {
                // look up instance from rmi
                GumballMachineRemote machine = (GumballMachineRemote) Naming.lookup(locations[i]);
                monitors[i] = new GumballMonitor(machine);
                System.out.println(monitors[i]);
            } catch (RemoteException e) {
                e.printStackTrace();
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

        for (int i = 0; i < monitors.length; i++) {
            monitors[i].Report();
        }
    }
}
