using System.Text;
using CommandPattern.Command;

namespace CommandPattern;

public class RemoteControl
{
    public ICommand[] OnCommands { get; set; }
    
    public ICommand[] OffCommands { get; set; }
    
    public ICommand UndoCommand { get; set; }

    public RemoteControl()
    {
        OnCommands = new ICommand[4];
        OffCommands = new ICommand[4];

        ICommand noCommand = new NoOp();

        for (int i = 0; i < 4; i++)
        {
            OnCommands[i] = noCommand;
            OffCommands[i] = noCommand;
        }

        UndoCommand = noCommand;
    }

    public void OnButtonPressed(int slot)
    {
        OnCommands[slot].Execute();
        UndoCommand = OnCommands[slot];
    }

    public void OffButtonPressed(int slot)
    {
        OffCommands[slot].Execute();
        UndoCommand = OffCommands[slot];
    }

    public void UndoButtonPressed()
    {
        UndoCommand.Undo();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < OnCommands.Length; i++)
        {
            sb.Append($"slot {i}: {OnCommands[i].GetType().Name} {OffCommands[i].GetType().Name} \n");
        }

        return sb.ToString();
    }
}