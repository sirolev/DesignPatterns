using System;

namespace Chapter2
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            ((ISubject)weatherData).RegisterObserver(this);
        }

        void IObserver.Update()
        {
            _temperature = _weatherData.Temperature;
            _humidity = _weatherData.Humidity;
            ((IDisplayElement)this).Display();
        }

        void IDisplayElement.Display()
        {
            Console.WriteLine("Current conditions: " + _temperature
                + "F degreees and " + _humidity + "% humidity");
        }
    }
}

