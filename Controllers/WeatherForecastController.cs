using Microsoft.AspNetCore.Mvc;
using Proyecto_Entrevista.Models;

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
                MiFer = true,
                Age = 14
            })
            .ToArray();
        }

        //End-point Post uwu*
        [HttpPost(Name = "PostWeatherForecast")]
        public Estudiante Post(Estudiante estudiante)
        {
            return new Estudiante
            {
                Name = estudiante.Name,
                Calificacion = estudiante.Calificacion,
                Acreditado = estudiante.Acreditado,
                Age = estudiante.Age,
            };
        }
    }
}