namespace StatePattern.States;

public class WinnerState : IState
{
    private Context Context { get; }

    public WinnerState(Context context)
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
        else
        {
            Context.CurrentState = Context.SoldOutState;
        }
    }
}