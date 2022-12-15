using CompositePattern.Components;

namespace CompositePattern.Iterators;

public class MenuComponentIterator : IIterator
{
    private readonly List<MenuComponent> _components;

    private int _position = 0;

    public MenuComponentIterator(List<MenuComponent> components)
    {
        _components = components;
    }
    
    public bool HasNext()
    {
        if (_position == _components.Count)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public object Next()
    {
        return _components[_position++];
    }
}