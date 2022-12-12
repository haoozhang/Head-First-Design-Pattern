namespace CommandPattern.Command.DoorCommand;

public class Door
{
    public void On()
    {
        Console.WriteLine("Door is on!");
    }

    public void Off()
    {
        Console.WriteLine("Door is off!");
    }
}