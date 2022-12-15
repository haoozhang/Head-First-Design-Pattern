package Iterators;


import Menus.MenuItem;
import java.util.Iterator;

public class DinerMenuIterator implements Iterator
{
    private final MenuItem[] MenuItems;

    private int _position = 0;

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        MenuItems = menuItems;
    }

    @Override
    public boolean hasNext() {
        if (_position >= MenuItems.length || MenuItems[_position] == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    @Override
    public Object next() {
        return MenuItems[_position++];
    }

}
