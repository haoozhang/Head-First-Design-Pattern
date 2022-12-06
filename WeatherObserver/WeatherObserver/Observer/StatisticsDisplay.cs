using WeatherObserver.Data;
using WeatherObserver.Display;
using WeatherObserver.Subject;

namespace WeatherObserver.Observer;

public class StatisticsDisplay : IObserver, IDisplay
{
    private WeatherData _minWeatherData;
    
    private WeatherData _maxWeatherData;
    
    private WeatherData _avgWeatherData;

    private int WeatherDataCount;

    private ISubject WeatherStation;

    public StatisticsDisplay(ISubject subject)
    {
        _minWeatherData = new WeatherData();
        _maxWeatherData = new WeatherData();
        _avgWeatherData = new WeatherData();
        WeatherDataCount = 0;
        
        WeatherStation = subject;
        WeatherStation.RegisterObserver(this);
    }

    public void UnregisterObserver()
    {
        WeatherStation.RemoveObserver(this);
    }
    
    public void Update(WeatherData weatherData)
    {
        if (_minWeatherData.Temperature == 0 && _minWeatherData.Humidity == 0 && _minWeatherData.Pressure == 0)
        {
            _minWeatherData.Temperature = weatherData.Temperature;
            _minWeatherData.Humidity = weatherData.Humidity;
            _minWeatherData.Pressure = weatherData.Pressure;
        }
        else
        {
            _minWeatherData.Temperature = Math.Min(_minWeatherData.Temperature, weatherData.Temperature);
            _minWeatherData.Humidity = Math.Min(_minWeatherData.Humidity, weatherData.Humidity);
            _minWeatherData.Pressure = Math.Min(_minWeatherData.Pressure, weatherData.Pressure);
        }
        
        _maxWeatherData.Temperature = Math.Max(_minWeatherData.Temperature, weatherData.Temperature);
        _maxWeatherData.Humidity = Math.Max(_minWeatherData.Humidity, weatherData.Humidity);
        _maxWeatherData.Pressure = Math.Max(_minWeatherData.Pressure, weatherData.Pressure);

        int newWeatherDataCount = WeatherDataCount + 1;
        
        _avgWeatherData.Temperature = (_avgWeatherData.Temperature * WeatherDataCount + weatherData.Temperature) / newWeatherDataCount;
        _avgWeatherData.Humidity = (_avgWeatherData.Humidity * WeatherDataCount + weatherData.Humidity) / newWeatherDataCount;
        _avgWeatherData.Pressure = (_avgWeatherData.Pressure * WeatherDataCount + weatherData.Pressure) / newWeatherDataCount;
        
        WeatherDataCount = newWeatherDataCount;
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Min: {_minWeatherData.Temperature}, {_minWeatherData.Humidity}, {_minWeatherData.Pressure}");
        Console.WriteLine($"Max: {_maxWeatherData.Temperature}, {_maxWeatherData.Humidity}, {_maxWeatherData.Pressure}");
        Console.WriteLine($"Avg: {_avgWeatherData.Temperature}, {_avgWeatherData.Humidity}, {_avgWeatherData.Pressure}");
    }
}