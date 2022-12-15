namespace IteratorPattern.Iterators;

public class DinerMenuIterator : IIterator
{
    private readonly MenuItem[] MenuItems;

    private int _position = 0;

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        MenuItems = menuItems;
    }
    
    public bool HasNext()
    {
        if (_position >= MenuItems.Length || MenuItems[_position] == null)
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
        return MenuItems[_position++];
    }
}