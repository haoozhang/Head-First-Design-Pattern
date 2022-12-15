using CompositePattern.Iterators;

namespace CompositePattern.Components;

public class Menu : MenuComponent
{
    public List<MenuComponent> Components { get; set; }
    
    public string Name { get; set; }
    
    public string Description { get; set; }

    public Menu(string name, string description)
    {
        Components = new List<MenuComponent>();
        Name = name;
        Description = description;
    }
    
    public override void Add(MenuComponent component)
    {
        Components.Add(component);
    }

    public override void Remove(MenuComponent component)
    {
        Components.Remove(component);
    }

    public override MenuComponent GetChild(int i)
    {
        return Components[i];
    }

    public override void Print()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Description: " + Description);
        Console.WriteLine("============");

        IIterator iterator = CreateIterator();
        while (iterator.HasNext())
        {
            var component = iterator.Next() as MenuComponent;
            component?.Print();
        }
        
    }
    
    public override IIterator CreateIterator()
    {
        return new MenuComponentIterator(Components);
    } 
}