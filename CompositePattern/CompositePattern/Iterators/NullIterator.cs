namespace CompositePattern.Iterators;

public class NullIterator : IIterator
{
    public bool HasNext()
    {
        return false;
    }

    public object Next()
    {
        return null;
    }
}