namespace CommandPattern.Command.FanCommand;

public class Fan
{
    public const int HIGH = 3;
    public const int MEDIUM = 2;
    public const int LOW = 1;
    public const int OFF = 0;
    
    public int Speed { get; set; }
    
    public void High()
    {
        Speed = HIGH;
        Console.WriteLine("Fan is high speed!");
    }

    public void Medium()
    {
        Speed = MEDIUM;
        Console.WriteLine("Fan is medium speed!");
    }
    
    public void Low()
    {
        Speed = LOW;
        Console.WriteLine("Fan is low speed!");
    }
    
    public void Off()
    {
        Speed = OFF;
        Console.WriteLine("Fan is off!");
    }
}