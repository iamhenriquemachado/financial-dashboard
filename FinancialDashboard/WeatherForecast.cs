namespace FinancialDashboard
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 34 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
