namespace FluentWeather.Models;

public class WeatherNow
{
    public DateTime obsTime  // 实际观测时间
    {
        get; set;
    }
    public int Temperature
    {
        get; set;
    }
    public int FeelsLike  // 体感温度
    {
        get; set;
    }
    public string Icon  // 和风天气图标
    {
        get; set;
    } = string.Empty;
    public string Description
    {
        get; set;
    } = string.Empty;
    public int Wind360  // 风向360角度
    {
        get; set;
    }
    public string WindDir  // 风向
    {
        get; set;
    } = string.Empty;
    public int WindScale  // 风力等级
    {
        get; set;
    }
    public int WindSpeed  // 风速，默认为公里/小时
    {
        get; set;
    }
    public int Humidity  // 相对湿度
    {
        get; set;
    }
    public decimal Precip  // 过去1h降水量
    {
        get; set;
    }
    public int Pressure  // 大气压强，单位为百帕
    {
        get; set;
    }
    public int Vis  // 能见度，默认单位为公里
    {
        get; set;
    }
    public int? Cloud  // 云量
    {
        get; set;
    }
    public int? Dew  // 露点温度
    {
        get; set;
    }
}