
// Adapter Pattern

using AdapterPattern.Adapter;
using AdapterPattern.Ducks;
using AdapterPattern.Turkeys;

namespace AdapterPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallarDuck();
            duck.Fly();
            duck.Quack();

            ITurkey turkey = new WildTurkey();
            TurkeyAdapter adapter = new TurkeyAdapter(turkey);
            adapter.Fly();
            adapter.Quack();
        }
    }
}