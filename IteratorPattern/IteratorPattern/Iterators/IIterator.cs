namespace IteratorPattern.Iterators;

public interface IIterator
{
    public bool HasNext();

    public object Next();
}