namespace CommandPattern.Command.DoorCommand;

public class DoorOff : ICommand
{
    public Door Door { get; set; }

    public DoorOff(Door door)
    {
        Door = door;
    }
    
    public void Execute()
    {
        Door.Off();
    }

    public void Undo()
    {
        Door.On();
    }
}