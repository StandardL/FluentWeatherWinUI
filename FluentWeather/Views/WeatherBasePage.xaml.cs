using FluentWeather.Models;
using FluentWeather.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System.Globalization;

namespace FluentWeather.Views;

public sealed partial class WeatherBasePage : Page
{
    WeatherBaseViewModel ViewModel { get; }
    public string strLocationName { get; set; } = string.Empty;
    public string strLocationUpdateTimeMainText { get; set; } = "最后更新于";
    public string strLocationUpdateTime { get; set; } = string.Empty;
    public string strWeatherInfo { get; set; } = string.Empty;
    public string strWeatherNowTemp { get; set; } = "NA";

    public WeatherBasePage()
    {
        ViewModel = App.GetService<WeatherBaseViewModel>();
        InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
        var location = e.Parameter as WeatherLocation;
        // TODO: 多单位
        if (location != null)
        {
            //ViewModel.SelectedLocation = location;
            strLocationName = location.LocationName;
            strWeatherInfo = location.Weather.weatherNow.Description;
            strWeatherNowTemp = location.Weather.weatherNow.Temperature.ToString() + "°C";
            strLocationUpdateTime = location.Weather.updateTime.ToString(CultureInfo.CurrentCulture);
        }
    }

}
