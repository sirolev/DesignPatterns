using System;

namespace Chapter2
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            ((ISubject)weatherData).RegisterObserver(this);
        }

        void IObserver.Update()
        {
            _lastPressure = _currentPressure;
            _currentPressure = _weatherData.Pressure;
            ((IDisplayElement)this).Display();
        }

        void IDisplayElement.Display()
        {
            Console.Write("Forecast: ");
            if (_currentPressure > _lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (_currentPressure == _lastPressure)
                Console.WriteLine("More of the same");
            else if (_currentPressure < _lastPressure)
                Console.WriteLine("Watch our for cool, rainy weather");
        }
    }
}

