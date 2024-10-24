namespace FluentWeather.Models;

public class Location
{
    public string Name { get; set; } = string.Empty;
    public int Id { get; set; }
    public decimal Lat { get; set; }
    public decimal Lon { get; set; }
    public string Adm2 { get; set; } = string.Empty;  // 二级行政区
    public string Adm1 { get; set; } = string.Empty;  // 一级行政区
    public string Country { get; set; } = string.Empty;
    public string TimeZone { get; set; } = string.Empty;
    public string UtcOffset { get; set; } = string.Empty;  // 时区偏移
    public int isDst { get; set; }  // 是否为夏令时
    public string Type { get; set; } = string.Empty;  // 地点类型
    public int Rank { get; set; }  // 地点评分
    public string FxLink { get; set; } = string.Empty;

}
