namespace FluentWeather.Models;

public class WeatherHours
{
    public DateTime fxTime { get; set; }  // 预报时间
    public int temp { get; set; }  // 温度，默认单位：摄氏度
    public int icon { get; set; }  // 天气图标代码
    public string text { get; set; } = string.Empty;  // 天气现象文字
    public int wind360 { get; set; }  // 风向360角度
    public string windDir { get; set; } = string.Empty;  // 风向
    public string windScale { get; set; } = string.Empty;  // 风力等级
    public int windSpeed { get; set; }  // 风速，公里/小时
    public int humidity { get; set; }  // 相对湿度, %
    public int? pop { get; set; }  // 降水概率
    public decimal precip { get; set; }  // 小时累计降水量，mm
    public int pressure { get; set; }  // 气压
    public int? cloud { get; set; }  // 云量
    public int? dew { get; set; }  // 露点温度

    public string TempText { get => $"{temp}°C"; }  // TODO: 多单位
    public string TimeText { get => $"{fxTime.Hour}"; }
    public string PrecipText { get => $"{precip}mm"; }
}
