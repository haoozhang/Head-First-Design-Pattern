using StatePattern.States;

namespace StatePattern;

public class Context
{
    public NoQuarterState NoQuarterState { get; }
    
    public HasQuarterState HasQuarterState { get; }
    
    public SoldState SoldState { get; }
    
    public SoldOutState SoldOutState { get; }
    
    public WinnerState WinnerState { get; }

    public IState CurrentState { get; set; }

    public int Count;

    public Context(int count)
    {
        NoQuarterState = new NoQuarterState(this);
        HasQuarterState = new HasQuarterState(this);
        SoldState = new SoldState(this);
        SoldOutState = new SoldOutState(this);
        WinnerState = new WinnerState(this);
        
        CurrentState = NoQuarterState;
        Count = count;
    }

    public void InsertQuarter()
    {
        CurrentState.InsertQuarter();
    }

    public void EjectQuarter()
    {
        CurrentState.EjectQuarter();
    }

    public void TurnCrank()
    {
        CurrentState.TurnCrank();
        CurrentState.Dispense();
    }

    public void ReleaseBall()
    {
        Console.WriteLine("Released a ball!");
        Count--;
    }
}