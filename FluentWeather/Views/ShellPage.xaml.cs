using FluentWeather.Contracts.Services;
using FluentWeather.Helpers;
using FluentWeather.Models;
using FluentWeather.ViewModels;
using Microsoft.UI.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Windows.Foundation;
using Windows.System;

namespace FluentWeather.Views;

// TODO: Update NavigationViewItem titles and icons in ShellPage.xaml.
public sealed partial class ShellPage : Page
{
    public ShellViewModel ViewModel
    {
        get;
    }

    public ShellPage(ShellViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();

        ViewModel.NavigationService.Frame = ContentFrame;
        ViewModel.NavigationViewService.Initialize(NavigationViewControl);

        // TODO: Set the title bar icon by updating /Assets/WindowIcon.ico.
        // A custom title bar is required for full window theme and Mica support.
        // https://docs.microsoft.com/windows/apps/develop/title-bar?tabs=winui3#full-customization
        App.MainWindow.ExtendsContentIntoTitleBar = true;
        App.MainWindow.SetTitleBar(AppTitleBar);
        App.MainWindow.Activated += MainWindow_Activated;
        AppTitleBarText.Text = "AppDisplayName".GetLocalized();
    }

    private void OnLoaded(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        TitleBarHelper.UpdateTitleBar(RequestedTheme);
        SetRegionsForCustomTitleBar();

        KeyboardAccelerators.Add(BuildKeyboardAccelerator(VirtualKey.Left, VirtualKeyModifiers.Menu));
        KeyboardAccelerators.Add(BuildKeyboardAccelerator(VirtualKey.GoBack));

        // 检查是否已有数据
        if (ViewModel.Locations.Count > 0)
        {
            NavigationViewControl.SelectedItem = ViewModel.Locations[0];
            //NavigationFrame.Navigate(typeof(WeatherBasePage), ViewModel.Locations[0]);
        }
        else
        {
            // TODO: 增加空白欢迎页，引导用户添加城市
        }
    }

    private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
    {
        App.AppTitlebar = AppTitleBarText as UIElement;
    }

    private void NavigationViewControl_DisplayModeChanged(NavigationView sender, NavigationViewDisplayModeChangedEventArgs args)
    {
        AppTitleBar.Margin = new Thickness()
        {
            Left = sender.CompactPaneLength * (sender.DisplayMode == NavigationViewDisplayMode.Minimal ? 2 : 1),
            Top = AppTitleBar.Margin.Top,
            Right = AppTitleBar.Margin.Right,
            Bottom = AppTitleBar.Margin.Bottom
        };
    }

    private static KeyboardAccelerator BuildKeyboardAccelerator(VirtualKey key, VirtualKeyModifiers? modifiers = null)
    {
        var keyboardAccelerator = new KeyboardAccelerator() { Key = key };

        if (modifiers.HasValue)
        {
            keyboardAccelerator.Modifiers = modifiers.Value;
        }

        keyboardAccelerator.Invoked += OnKeyboardAcceleratorInvoked;

        return keyboardAccelerator;
    }

    private static void OnKeyboardAcceleratorInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
        var navigationService = App.GetService<INavigationService>();

        var result = navigationService.GoBack();

        args.Handled = result;
    }

    private void NavigationViewItem_RightTapped(object sender, RightTappedRoutedEventArgs e)
    {
        var navigationViewItem = sender as NavigationViewItem;
        if (navigationViewItem != null)
        {
            MenuFlyout menuFlyout = new MenuFlyout();

            // 添加菜单项
            var deleteItem = new MenuFlyoutItem { Text = "删除", Icon = new SymbolIcon(Symbol.Delete) };  // TODO: Localize this string
            deleteItem.Click += (s, args) =>
            {
                // 删除逻辑
                var locationToRemove = ViewModel.Locations.FirstOrDefault(loc => loc.LocationName == navigationViewItem.Tag.ToString());
                if (locationToRemove != null)
                {
                    ViewModel.Locations.Remove(locationToRemove);
                }
            };
            menuFlyout.Items.Add(deleteItem);

            // 显示菜单
            menuFlyout.ShowAt(navigationViewItem, e.GetPosition(navigationViewItem));
        }
    }

    private void NavigationViewControl_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        var selectedItem = args.SelectedItem as WeatherLocation;
        if (selectedItem != null)
        {
            ContentFrame.Navigate(typeof(WeatherBasePage), selectedItem);
        }
    }

    private void SetRegionsForCustomTitleBar()
    {
        // 给搜索框扣个洞
        double scaleAdjustment = AppTitleBar.XamlRoot.RasterizationScale;
        GeneralTransform transform = TitlebarSearchBox.TransformToVisual(null);
        Rect bounds = transform.TransformBounds(new Rect(0, 0,
                                                         TitlebarSearchBox.ActualWidth,
                                                         TitlebarSearchBox.ActualHeight));
        Windows.Graphics.RectInt32 PersonPicRect = GetRect(bounds, scaleAdjustment);
        Windows.Graphics.RectInt32 SearchBoxRect = GetRect(bounds, scaleAdjustment);
        var rectArray = new Windows.Graphics.RectInt32[] { SearchBoxRect, PersonPicRect };

        InputNonClientPointerSource nonClientInputSrc =
            InputNonClientPointerSource.GetForWindowId(App.MainWindow.AppWindow.Id);
        nonClientInputSrc.SetRegionRects(NonClientRegionKind.Passthrough, rectArray);

    }

    private Windows.Graphics.RectInt32 GetRect(Rect bounds, double scale)
    {
        return new Windows.Graphics.RectInt32(
            _X: (int)Math.Round(bounds.X * scale),
            _Y: (int)Math.Round(bounds.Y * scale),
            _Width: (int)Math.Round(bounds.Width * scale),
            _Height: (int)Math.Round(bounds.Height * scale)
        );
    }
}
