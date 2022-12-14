using AdapterPattern.Ducks;
using AdapterPattern.Turkeys;

namespace AdapterPattern.Adapter;

public class TurkeyAdapter : IDuck
{
    public ITurkey Turkey { get; set; }

    public TurkeyAdapter(Turkeys.ITurkey turkey)
    {
        Turkey = turkey;
    }
    
    public void Fly()
    {
        Turkey.Fly();
    }

    public void Quack()
    {
        for (int i = 0; i < 5; i++)
        {
            Turkey.Gobble();
        }
    }
}