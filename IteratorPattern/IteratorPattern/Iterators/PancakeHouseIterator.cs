namespace IteratorPattern.Iterators;

public class PancakeHouseIterator : IIterator
{
    private readonly List<MenuItem> _menuItems;

    private int _position = 0;

    public PancakeHouseIterator(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }
    
    public bool HasNext()
    {
        if (_position == _menuItems.Count)
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
        return _menuItems[_position++];
    }
}