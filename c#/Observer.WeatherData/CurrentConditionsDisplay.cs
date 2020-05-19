namespace HeadFirstDesignPatterns.Observer.WeatherData
{
    /// <summary>
    /// Summary description for CurrentConditionsDisplay.
    /// </summary>
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float humidity;
        private float pressure;
        private float temperature;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #region IDisplayElement Members

        public object Display() =>
            "Current conditions: " + temperature + "F degrees and " +
            humidity + "% humidity";

        #endregion

        #region IObserver Members

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }

        #endregion
    }
}