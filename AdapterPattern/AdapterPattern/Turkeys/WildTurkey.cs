namespace AdapterPattern.Turkeys;

public class WildTurkey : Turkeys.ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("I'm Gobbling!");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying for short distance!");
    }
}