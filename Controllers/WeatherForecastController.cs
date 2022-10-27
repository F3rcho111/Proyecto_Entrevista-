using Microsoft.AspNetCore.Mvc;

namespace Proyecto_Entrevista.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //End-point Tipo Get uwu 
        //Padre que se vea que hago push <3
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                MiFer = true
            })
            .ToArray();
        }
        
        //End-point Post uwu*
        [HttpPost(Name = "PostWeatherForecast")]
        public WeatherForecast Post(WeatherForecast weatherForecast)
        {
            return new WeatherForecast
            {
                Date = weatherForecast.Date,
                TemperatureC = weatherForecast.TemperatureC,
                Summary = weatherForecast.Summary,
                MiFer = weatherForecast.MiFer
            };
        }
    }
}