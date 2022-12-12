using static CommandPattern.Command.FanCommand.Fan;

namespace CommandPattern.Command.FanCommand;

public class FanLow : ICommand
{
    public Fan Fan { get; set; }
    
    public int PrevSpeed { get; set; }

    public FanLow(Fan fan)
    {
        Fan = fan;
    }
    
    public void Execute()
    {
        PrevSpeed = Fan.Speed;
        Fan.Low();
    }

    public void Undo()
    {
        if (PrevSpeed == HIGH)
        {
            Fan.High();
        }
        else if (PrevSpeed == MEDIUM) 
        {
            Fan.Medium();
        }
        else if (PrevSpeed == LOW)
        {
            Fan.Low();
        }
        else if (PrevSpeed == OFF)
        {
            Fan.Off();
        }
    }
}