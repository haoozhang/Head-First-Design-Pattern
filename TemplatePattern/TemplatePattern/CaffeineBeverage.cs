using System.Globalization;

namespace TemplatePattern;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();

        Brew();

        PourInCup();

        if (CustomerWantCondiments())
        {
            AddCondiments();
        }
    }

    public void BoilWater()
    {
        Console.WriteLine("Boil Water....");
    }

    protected abstract void Brew();

    public void PourInCup()
    {
        Console.WriteLine("Pour In Cup....");
    }

    protected abstract void AddCondiments();

    public virtual bool CustomerWantCondiments()
    {
        return true;
    }
}