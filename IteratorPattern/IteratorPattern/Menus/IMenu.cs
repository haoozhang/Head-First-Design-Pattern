using IteratorPattern.Iterators;

namespace IteratorPattern.Menus;

public interface IMenu
{
    public IIterator CreateIterator();
}