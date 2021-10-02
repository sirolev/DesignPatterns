using System;

namespace Chapter2
{
    public class WeatherStation
    {
        WeatherData weatherData = new WeatherData();

        public WeatherStation()
        {
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            Console.WriteLine("-------------");
            weatherData.SetMeasurements(82, 70, 29.2f);
            Console.WriteLine("-------------");
            weatherData.SetMeasurements(78, 90, 29.2f);
        }
    }
}