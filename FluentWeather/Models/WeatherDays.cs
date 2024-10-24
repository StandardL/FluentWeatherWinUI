using FluentWeather.Core.Helpers;

namespace FluentWeather.Models;

public class WeatherDays
{
    public DateTime fxDate { get; set; }
    public string? sunrise { get; set; }  // 日出时间，高纬度地区可能为空
    public string? sunset { get; set; }  // 日落时间，高纬度地区可能为空
    public string? moonrise { get; set; }  // 月升时间，可能为空
    public string? moonset { get; set; }  // 月落时间，可能为空
    public string moonPhase { get; set; } = string.Empty; // 月相名称
    public int moonPhaseIcon { get; set; } = -1; // 月相图标
    public int tempMax { get; set; } // 最高温度
    public int tempMin { get; set; } // 最低温度
    public int iconDay { get; set; }  // 白天天气状况的图标代码
    public string textDay { get; set; } = string.Empty;  // 白天天气状况的文字描述
    public int iconNight { get; set; }
    public string textNight { get; set; } = string.Empty;
    public int wind360Day { get; set; }
    public string windDirDay { get; set; } = string.Empty;  // 白天风向
    public string windScaleDay { get; set; } = string.Empty;  // 白天风力
    public int windSpeedDay { get; set; }  // 白天风速，公里/小时
    public int wind360Night { get; set; }
    public string windDirNight { get; set; } = string.Empty;
    public string windScaleNight { get; set; } = string.Empty;
    public int windSpeedNight { get; set; }
    public int humidity { get; set; }  // 相对湿度，百分比数值
    public decimal precip { get; set; }  // 预报总降水量，毫米
    public int pressure { get; set; }  // 大气压强，百帕
    public int vis { get; set; }  // 能见度，公里
    public int? cloud { get; set; }  // 云量，百分比数值
    public int uvIndex { get; set; }  // 紫外线强度指数

    public string TempText { get => $"{tempMax}°C / {tempMin}°C"; }  // TODO: 多单位
    public string DateText { get => $"{fxDate.Day} {LocalizationWeekDays.dicLocalization["zh-cn"][fxDate.DayOfWeek]}"; }  // TODO: 多语言
}
