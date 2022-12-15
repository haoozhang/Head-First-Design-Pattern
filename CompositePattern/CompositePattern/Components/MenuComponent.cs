using CompositePattern.Iterators;

namespace CompositePattern.Components;

public abstract class MenuComponent
{
    public abstract void Add(MenuComponent component);

    public abstract void Remove(MenuComponent component);

    public abstract MenuComponent GetChild(int i);

    public abstract void Print();

    public abstract IIterator CreateIterator();
}