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

        //End-point Tipo Get 
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            
            
            var test = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now,
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                MiFer = true,
                Age = 14
            })
            .ToArray();

            return test;
        }

        //End-point Post
        [HttpPost(Name = "PostWeatherForecast")]
        public Estudiante Post(Estudiante estudiante)
        {
            return new Estudiante
            {
                Name = estudiante.Name,
                Calificacion = estudiante.Calificacion,
                Acreditado = estudiante.Acreditado,
                Age = estudiante.Age,
                Grado = estudiante.Grado,   
            };
        }
    }
}