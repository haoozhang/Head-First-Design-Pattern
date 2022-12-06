using WeatherObserver.Data;
using WeatherObserver.Display;
using WeatherObserver.Subject;

namespace WeatherObserver.Observer;

public class CurrentConditionDisplay : IObserver, IDisplay
{
    private WeatherData _weatherData;

    private ISubject WeatherStation;

    public CurrentConditionDisplay(ISubject subject)
    {
        _weatherData = new WeatherData();
        
        WeatherStation = subject;
        WeatherStation.RegisterObserver(this);
    }
    
    public void UnregisterObserver()
    {
        WeatherStation.RemoveObserver(this);
    }
    
    public void Update(WeatherData weatherData)
    {
        _weatherData = weatherData;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current condition: {_weatherData.Temperature}, {_weatherData.Humidity}, {_weatherData.Pressure} ");
    }
}