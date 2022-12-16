namespace StatePattern.States;

public class SoldState : IState
{
    private Context Context { get; }

    public SoldState(Context context)
    {
        Context = context;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You have inserted one quarter, can't insert another one!");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You have turned crank, can't eject the quarter!");
    }

    public void TurnCrank()
    {
        Console.WriteLine("You have turned crank once!");
    }

    public void Dispense()
    {
        Console.WriteLine("Dispense!");
        
        Context.ReleaseBall();
        if (Context.Count > 0)
        {
            Context.CurrentState = Context.NoQuarterState;
        }
        else
        {
            Context.CurrentState = Context.SoldOutState;
        }
    }
}