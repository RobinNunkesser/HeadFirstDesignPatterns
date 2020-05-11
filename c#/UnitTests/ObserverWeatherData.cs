using System;
using HeadFirstDesignPatterns.Observer.WeatherData;
using Xunit;

namespace UnitTests
{
    public class ObserverWeatherData
    {

        #region Members
        static WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditionsDisplay =
                new CurrentConditionsDisplay(weatherData);
        ForcastDisplay forcastDisplay = new ForcastDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
        #endregion//Members

        #region TestCurrentConditionsDisplay
        [Fact]
        public void TestCurrentConditionsDisplay()
        {
            weatherData.SetMeasurements(80, 65, 30.4f);

            Assert.Equal("Current conditions: 80F degrees and 65% humidity",
                currentConditionsDisplay.Display());
        }
        #endregion//TestCurrentConditionsDisplay

        #region TestForecastDisplay
        [Fact]
        public void TestForecastDisplay()
        {
            weatherData.SetMeasurements(81, 63, 31.2f);
            //lastPressure = 29.92f
            Assert.Equal("Forecast: Improving weather on the way!",
                forcastDisplay.Display());

            weatherData.SetMeasurements(81, 63, 29.92f);
            Assert.Equal("Forecast: Watch out for cooler, rainy weather",
                forcastDisplay.Display());

            weatherData.SetMeasurements(81, 63, 29.92f);
            Assert.Equal("Forecast: More of the same",
                forcastDisplay.Display());
        }
        #endregion//TestForecastDisplay

        #region TestStatisticsDisplay
        [Fact]
        public void TestStatisticsDisplay()
        {
            weatherData.SetMeasurements(80, 63, 31.2f);
            weatherData.SetMeasurements(81, 63, 29.92f);
            weatherData.SetMeasurements(84, 63, 29.92f);
            if (statisticsDisplay.NumberOfReadings == 3)
            {
                Assert.Equal("Avg/Max/Min temperature = 81.667F/84F/80F",
                    statisticsDisplay.Display());
            }
            if (statisticsDisplay.NumberOfReadings == 8)
            {
                Assert.Equal("Avg/Max/Min temperature = 81.00F/84F/80F",
                    statisticsDisplay.Display());
            }
        }
        #endregion//TestStatisticsDisplay

        #region TestHeatIndexDisplay
        [Fact]
        public void TestHeatIndexDisplay()
        {
            weatherData.SetMeasurements(80, 65, 31.2f);
            Assert.Equal("Heat index is 82.95535", heatIndexDisplay.Display());
        }
        #endregion//TestHeatIndexDisplay
    }
}
