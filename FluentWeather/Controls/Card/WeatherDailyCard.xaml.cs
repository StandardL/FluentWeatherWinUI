using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

namespace FluentWeather.Controls;
public sealed partial class WeatherDailyCard : UserControl
{
    public WeatherDailyCard()
    {
        this.InitializeComponent();
    }

    // TODO 看看怎么优化下，无数据时使用一个全局统一的值
    public static string DefaultText { get; set; } = "NA";

    public ImageSource MainIconSource
    {
        get { return (ImageSource)GetValue(MainIconSourceProperty); }
        set { SetValue(MainIconSourceProperty, value); }
    }
    public static readonly DependencyProperty MainIconSourceProperty =
        DependencyProperty.Register("MainIconSource",
            typeof(ImageSource),
            typeof(WeatherDailyCard),
            new PropertyMetadata(null));
    public ImageSource RainPerIconSource
    {
        get { return (ImageSource)GetValue(RainPerIconSourceProperty); }
        set { SetValue(RainPerIconSourceProperty, value); }
    }
    public static readonly DependencyProperty RainPerIconSourceProperty =
        DependencyProperty.Register("RainPerIconSource",
            typeof(ImageSource),
            typeof(WeatherDailyCard),
            new PropertyMetadata(null));

    public string DateText
    {
        get { return (string)GetValue(DateTextProperty); }
        set { SetValue(DateTextProperty, value); }
    }
    public static readonly DependencyProperty DateTextProperty =
        DependencyProperty.Register("DateText",
            typeof(string),
            typeof(WeatherDailyCard),
            new PropertyMetadata(DefaultText));

    public string TempText
    {
        get { return (string)GetValue(TempTextProperty); }
        set { SetValue(TempTextProperty, value); }
    }
    public static readonly DependencyProperty TempTextProperty =
        DependencyProperty.Register("TempText",
            typeof(string),
            typeof(WeatherDailyCard),
            new PropertyMetadata(DefaultText));

    public string RainPerText
    {
        get { return (string)GetValue(RainPerTextProperty); }
        set { SetValue(RainPerTextProperty, value); }
    }
    public static readonly DependencyProperty RainPerTextProperty =
        DependencyProperty.Register("RainPerText",
            typeof(string),
            typeof(WeatherDailyCard),
            new PropertyMetadata(DefaultText));
}
