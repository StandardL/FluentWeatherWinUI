namespace FluentWeather.Models;

public class WeatherLocation
{
    public int Id { get; set; }
    public string LocationName { get; set; } = string.Empty;
    public Weather Weather { get; set; } = new();
    public string DisplayText { get => $" {Weather.weatherNow.Temperature.ToString()}°C {Weather.weatherNow.Description}"; }  // TODO 多语言or多单位？
    public string IconUri { get => $"ms-appx:///Resource/Icon/{Weather.weatherNow.Icon}.svg"; }
}