namespace StatePattern.States;

public class HasQuarterState : IState
{
    private Random _random = new Random();
    
    private Context Context { get; }

    public HasQuarterState(Context context)
    {
        Context = context;
    }

    public void InsertQuarter()
    {
        Console.WriteLine("You have inserted one quarter, can't insert another one!");
    }

    public void EjectQuarter()
    {
        Console.WriteLine("You eject the quarter!");
        Context.CurrentState = Context.NoQuarterState;
    }

    public void TurnCrank()
    {
        Console.WriteLine("You turn the crank!");
        
        var isWined = _random.Next(10);
        if (isWined == 0)
        {
            Console.WriteLine("~$$~ You are the winner!");
            Context.CurrentState = Context.WinnerState;
        }
        else
        {
            Context.CurrentState = Context.SoldState;
        }
    }

    public void Dispense()
    {
        Console.WriteLine("You should turn crank!");
    }
}