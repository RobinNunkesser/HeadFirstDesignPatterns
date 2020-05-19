using System.Globalization;

namespace HeadFirstDesignPatterns.Observer.WeatherData
{
    /// <summary>
    /// Summary description for StatisticsDisplay.
    /// </summary>
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        #region Constructor

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #endregion //Constructor

        #region NumberOfReadings Property

        public int NumberOfReadings => numReadings;

        #endregion //NumberOfReadings Property

        #region IDisplayElement Members

        public object Display() =>
            "Avg/Max/Min temperature = " +
            RoundFloatToString(temperatureSum / numReadings) + "F/" +
            maxTemp + "F/" + minTemp + "F";

        #endregion

        #region IObserver Members

        public void Update(float temperature, float humidity, float pressure)
        {
            temperatureSum += temperature;
            numReadings++;

            if (temperature > maxTemp)
            {
                maxTemp = temperature;
            }

            if (temperature < minTemp)
            {
                minTemp = temperature;
            }
        }

        #endregion

        #region RoundFloatToString

        public static string RoundFloatToString(float floatToRound)
        {
            CultureInfo cultureInfo =
                new CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }

        #endregion //RoundFloatToString

        #region Members

        private float maxTemp = 0.0f;

        private float minTemp = 200; //set intial high so that minimum 

        //is set first invokation
        private float temperatureSum = 0.0f;
        private int numReadings = 0;
        private ISubject weatherData;

        #endregion //Members
    }
}