namespace StatePattern.States;

public class SoldOutState : IState
{
    private Context Context { get; }

    public SoldOutState(Context context)
    {
        Context = context;
    }
    
    public void InsertQuarter()
    {
        Console.WriteLine("Ball sold out, you can't insert quarter!");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't insert a quarter yet!");
    }

    public void TurnCrank()
    {
        Console.WriteLine("Ball sold out");
    }

    public void Dispense()
    {
        Console.WriteLine("Ball sold out");
    }
}