using WeatherObserver.Observer;

namespace WeatherObserver.Subject;

public interface ISubject
{
    public void RegisterObserver(IObserver observer);

    public void RemoveObserver(IObserver observer);

    public void NotifyObserver();
}