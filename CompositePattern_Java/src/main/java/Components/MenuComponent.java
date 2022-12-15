package Components;

import java.util.Iterator;

public abstract class MenuComponent
{
    public abstract void Add(MenuComponent component);

    public abstract void Remove(MenuComponent component);

    public abstract MenuComponent GetChild(int i);

    public abstract void Print();

    public abstract Iterator CreateIterator();
}
