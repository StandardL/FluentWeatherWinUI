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

namespace FluentWeather.Controls.Dialogs;

public sealed partial class SetKeyDialog : ContentDialog
{
    public string strTitle { get; set; } = "设置和风天气API KEY";
    public string strPrimaryBtnText { get; set; } = "保存";

    public SetKeyDialog()
    {
        this.InitializeComponent();
    }
}
