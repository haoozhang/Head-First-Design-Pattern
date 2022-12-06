using WeatherObserver.Data;
using WeatherObserver.Observer;

namespace WeatherObserver.Subject;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers;

    private WeatherData _weatherData;
    
    public WeatherData WeatherData
    {
        get => _weatherData;
        set
        {
            _weatherData = value;
            MeasurementsChanged();
        }
    }

    public WeatherStation()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObserver()
    {
        foreach (var observer in _observers)
        {
            observer.Update(WeatherData);
        }
    }

    private void MeasurementsChanged()
    {
        NotifyObserver();
    }
}