namespace CommandPattern.Command.DoorCommand;

public class DoorOn : ICommand
{
    public Door Door { get; set; }

    public DoorOn(Door door)
    {
        Door = door;
    }
    
    public void Execute()
    {
        Door.On();
    }

    public void Undo()
    {
        Door.Off();
    }
}