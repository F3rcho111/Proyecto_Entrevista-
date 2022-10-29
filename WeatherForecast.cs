namespace Proyecto_Entrevista
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 15 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public bool MiFer  { get; set; }
        public int Age { get; set; }

    }
}