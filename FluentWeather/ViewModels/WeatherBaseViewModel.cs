using CommunityToolkit.Mvvm.ComponentModel;
using FluentWeather.Models;
using FluentWeather.Models.Test;

namespace FluentWeather.ViewModels;

public partial class WeatherBaseViewModel : ObservableRecipient
{
    public WeatherLocation SelectedLocation { get; set; } = new();
    public WeatherBaseViewModel()
    {
        // 先用假数据
        SelectedLocation = Foo.FooWeather;
    }

}
