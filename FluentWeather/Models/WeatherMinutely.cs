namespace FluentWeather.Models;

public class WeatherMinutely
{
    public DateTime fxTime { get; set; }  // 预报时间
    public decimal precip { get; set; }  // 5分钟累计降水量，毫米
    public string type { get; set; } = string.Empty; // 降水类型，rain（雨）、snow（雪）
}