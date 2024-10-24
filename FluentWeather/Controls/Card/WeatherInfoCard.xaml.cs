using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace FluentWeather.Controls;
public sealed partial class WeatherInfoCard : UserControl
{
    public WeatherInfoCard()
    {
        this.InitializeComponent();
    }

    public ImageSource ImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }
    public static readonly DependencyProperty ImageSourceProperty =
        DependencyProperty.Register("ImageSource",
            typeof(ImageSource),
            typeof(WeatherInfoCard),
            new PropertyMetadata(null));

    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }
    public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register("Title",
            typeof(string),
            typeof(WeatherInfoCard),
            new PropertyMetadata(string.Empty));

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
    public static readonly DependencyProperty DescriptionProperty =
        DependencyProperty.Register("Description",
            typeof(string),
            typeof(WeatherInfoCard),
            new PropertyMetadata(string.Empty));

    public bool PressureVisible
    {
        get { return (bool)GetValue(pressureVisibleProperty); }
        set { SetValue(pressureVisibleProperty, value); }
    }
    public static readonly DependencyProperty pressureVisibleProperty =
        DependencyProperty.Register("bImgVisible",
            typeof(bool),
            typeof(WeatherInfoCard),
            new PropertyMetadata(true));
}
