using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;


namespace FluentWeather.Controls;
public sealed partial class WeatherHoursCard : UserControl
{
    public WeatherHoursCard()
    {
        InitializeComponent();
    }

    // TODO 看看怎么优化下，无数据时使用一个全局统一的值
    public static string DefaultText { get; set; } = "NA";

    public ImageSource WetIconSource
    {
        get { return (ImageSource)GetValue(WetIconSourceProperty); }
        set { SetValue(WetIconSourceProperty, value); }
    }
    public static readonly DependencyProperty WetIconSourceProperty =
        DependencyProperty.Register("WetIconSource",
            typeof(ImageSource),
            typeof(WeatherHoursCard),
            new PropertyMetadata(null));
    public ImageSource RainPerIconSource
    {
        get { return (ImageSource)GetValue(RainPerIconSourceProperty); }
        set { SetValue(RainPerIconSourceProperty, value); }
    }
    public static readonly DependencyProperty RainPerIconSourceProperty =
        DependencyProperty.Register("RainPerIconSource",
            typeof(ImageSource),
            typeof(WeatherHoursCard),
            new PropertyMetadata(null));

    public string TempText
    {
        get { return (string)GetValue(TempTextProperty); }
        set { SetValue(TempTextProperty, value); }
    }
    public static readonly DependencyProperty TempTextProperty =
        DependencyProperty.Register("TempText",
            typeof(string),
            typeof(WeatherHoursCard),
            new PropertyMetadata(DefaultText));

    public string DescText
    {
        get { return (string)GetValue(DescTextProperty); }
        set { SetValue(DescTextProperty, value); }
    }
    public static readonly DependencyProperty DescTextProperty =
        DependencyProperty.Register("DescText",
            typeof(string),
            typeof(WeatherHoursCard),
            new PropertyMetadata(DefaultText));

    public string RainPerText
    {
        get { return (string)GetValue(RainPerTextProperty); }
        set { SetValue(RainPerTextProperty, value); }
    }
    public static readonly DependencyProperty RainPerTextProperty =
        DependencyProperty.Register("RainPerText",
            typeof(string),
            typeof(WeatherHoursCard),
            new PropertyMetadata(DefaultText));

    public string HourText
    {
        get { return (string)GetValue(HourTextProperty); }
        set { SetValue(HourTextProperty, value); }
    }
    public static readonly DependencyProperty HourTextProperty =
        DependencyProperty.Register("HourText",
            typeof(string),
            typeof(WeatherHoursCard),
            new PropertyMetadata(DefaultText));
}
