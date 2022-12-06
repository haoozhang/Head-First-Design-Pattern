using WeatherObserver.Data;

namespace WeatherObserver.Observer;

public interface IObserver
{
    public void Update(WeatherData weatherData);
}