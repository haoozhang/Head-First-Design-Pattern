
using WeatherObserver.Data;
using WeatherObserver.Observer;
using WeatherObserver.Subject;

// Observer Pattern

namespace WeatherObserver
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            WeatherStation subject = new WeatherStation();

            // register observer 1
            StatisticsDisplay observer1 = new StatisticsDisplay(subject);

            WeatherData data = new WeatherData()
            {
                Temperature = 35,
                Humidity = 20,
                Pressure = 1000,
            };
            subject.WeatherData = data;

            // register observer 2
            CurrentConditionDisplay observer2 = new CurrentConditionDisplay(subject);
            
            data = new WeatherData()
            {
                Temperature = 40,
                Humidity = 25,
                Pressure = 2000,
            };
            subject.WeatherData = data;
            
            // unregister observer 2
            observer2.UnregisterObserver();
            
            data = new WeatherData()
            {
                Temperature = 45,
                Humidity = 30,
                Pressure = 3000,
            };
            subject.WeatherData = data;
        }
    }
}