namespace FluentWeather.Core.Helpers;
public class LocalizationWeekDays
{
    public static Dictionary<string, Dictionary<DayOfWeek, string>> dicLocalization = new()
    {
        {"zh-cn", new()
        {
            {DayOfWeek.Sunday, "周日"},
            {DayOfWeek.Monday, "周一"},
            {DayOfWeek.Tuesday, "周二"},
            {DayOfWeek.Wednesday, "周三"},
            {DayOfWeek.Thursday, "周四"},
            {DayOfWeek.Friday, "周五"},
            {DayOfWeek.Saturday, "周六"}
        }},
    };
}
