namespace StatePattern.States;

public class NoQuarterState : IState
{
    private Context Context { get; }

    public NoQuarterState(Context context)
    {
        Context = context;
    }
    
    public void InsertQuarter()
    {
        Console.WriteLine("You insert a quarter!");
        Context.CurrentState = Context.HasQuarterState;
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You haven't insert a quarter yet!");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You should insert a quarter first and then turn crank!");
    }

    public void Dispense()
    {
        Console.WriteLine("You need to insert a quarter first!");
    }
}