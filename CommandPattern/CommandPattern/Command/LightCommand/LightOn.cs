namespace CommandPattern.Command.LightCommand;

public class LightOn : ICommand
{
    public Light Light { get; set; }

    public LightOn(Light light)
    {
        Light = light;
    }
    
    public void Execute()
    {
        Light.On();
    }

    public void Undo()
    {
        Light.Off();
    }
}