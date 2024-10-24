namespace FluentWeather.Models;
public class Weather
{
    public DateTime updateTime { get; set; } // 请求时间（精确到分钟）
    public string fxLink { get; set; } = string.Empty; // 和风天气链接
    public WeatherNow weatherNow { get; set; } = new();

    public List<WeatherDays> daily { get; set; } = new();

    public List<WeatherMinutely> minutely { get; set; } = new();

    public List<WeatherHours> hourly { get; set; } = new();

    public string MinutelySummary { get; set; } = string.Empty; // 降水情况文本描述

    public Refer refer { get; set; } = new();
}
