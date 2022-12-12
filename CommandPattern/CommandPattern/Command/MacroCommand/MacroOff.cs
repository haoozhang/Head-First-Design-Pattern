namespace CommandPattern.Command.MacroCommand;

public class MacroOff : ICommand
{
    public ICommand[] Commands { get; set; }

    public MacroOff(ICommand[] commands)
    {
        Commands = commands;
    }
    
    public void Execute()
    {
        foreach (var command in Commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in Commands)
        {
            command.Undo();
        }
    }
}