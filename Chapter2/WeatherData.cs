using System.Collections.Generic;

namespace Chapter2
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData() =>
            _observers = new List<IObserver>();
        
        void ISubject.RegisterObserver(IObserver observer) =>
            _observers.Add(observer);
        
        void ISubject.RemoveObserver(IObserver observer) =>
            _observers.Remove(observer);
        
        void ISubject.NotifyObservers()
        {
            foreach (IObserver observer in _observers)
                observer.Update();
        }
        
        public void MeasurementsChanged() => 
            ((ISubject)this).NotifyObservers();
        
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            
            MeasurementsChanged();
        }
    }
}