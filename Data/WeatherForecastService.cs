namespace Zadanie11.Data
{
    public class WeatherForecastService
    {
        List<WeatherForecast> forecasts = new List<WeatherForecast>()
        {
            new WeatherForecast()
            {
                Id = 1,
                Date = new DateOnly(2023, 06, 01),
                TemperatureC = 25,
                Summary = "Sunny"
            },
            new WeatherForecast()
            {
                Id = 2,
                Date = new DateOnly(2023, 06, 02),
                TemperatureC = 21,
                Summary = "Cloudy"
            },
            new WeatherForecast()
            {
                Id = 3,
                Date = new DateOnly(2023, 06, 03),
                TemperatureC = 19,
                Summary = "Rainy"
            },
            new WeatherForecast()
            {
                Id = 4,
                Date = new DateOnly(2023, 06, 04),
                TemperatureC = 27,
                Summary = "Partly Cloudy"
            },
            new WeatherForecast()
            {
                Id = 5,
                Date = new DateOnly(2023, 06, 05),
                TemperatureC = 30,
                Summary = "Hot"
            }
        };
        public IEnumerable<WeatherForecast> GetForecast()
        {
            return forecasts;
        }
    }
}