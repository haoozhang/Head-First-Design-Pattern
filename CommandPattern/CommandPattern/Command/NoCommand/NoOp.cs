namespace CommandPattern.Command;

public class NoOp : ICommand
{
    public void Execute()
    {
    }

    public void Undo()
    {
    }
}