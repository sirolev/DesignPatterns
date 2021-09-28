using System;

namespace Chapter2
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            ((ISubject)weatherData).RegisterObserver(this);
        }

        void IObserver.Update()
        {
            _temperature = _weatherData.Temperature;
            _tempSum += _temperature;
            _numReadings++;

            if (_temperature > _maxTemp)
                _maxTemp = _temperature;
            
            if (_temperature < _minTemp)
                _minTemp = _temperature;

            ((IDisplayElement)this).Display();
        }

        void IDisplayElement.Display()
        {
            Console.WriteLine("Avg/Max/Min temperature = "+ (_tempSum / _numReadings)
                + "/" + _maxTemp + "/" + _minTemp);
        }
    }
}

