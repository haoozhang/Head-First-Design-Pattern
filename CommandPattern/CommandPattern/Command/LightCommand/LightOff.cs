namespace CommandPattern.Command.LightCommand;

public class LightOff : ICommand
{
    public Light Light { get; set; }

    public LightOff(Light light)
    {
        Light = light;
    }
    
    public void Execute()
    {
        Light.Off();
    }

    public void Undo()
    {
        Light.On();
    }
}