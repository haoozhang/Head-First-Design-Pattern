import java.net.MalformedURLException;
import java.rmi.Naming;
import java.rmi.RemoteException;

public class GumballMachineTest {

    public static void main(String[] args) {
        try {
            GumballMachineRemote gumballMachine = new Context(10, "sane");
            Naming.rebind("rmi://localhost:5001/sane", gumballMachine);
            System.out.println("Registered sane");

            GumballMachineRemote gumballMachine2 = new Context(20, "boulder");
            Naming.rebind("rmi://localhost:5001/boulder", gumballMachine2);
            System.out.println("Registered boulder");
        } catch (RemoteException | MalformedURLException e) {
            e.printStackTrace();
        }
    }
}
