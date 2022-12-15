using CompositePattern.Iterators;

namespace CompositePattern.Components;

public class MenuItem : MenuComponent
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public double Price { get; set; }

    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }
    
    public override void Add(MenuComponent component)
    {
        throw new InvalidOperationException("Can't add for menu item!");
    }

    public override void Remove(MenuComponent component)
    {
        throw new InvalidOperationException("Can't add for menu item!");
    }

    public override MenuComponent GetChild(int i)
    {
        throw new InvalidOperationException("Can't add for menu item!");
    }

    public override void Print()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("Price: " + Price);
    }

    public override IIterator CreateIterator()
    {
        return new NullIterator();
    }
}