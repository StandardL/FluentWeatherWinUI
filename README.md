# FluentWeather

## 更新日志

### 2024-10-24 (Updated)
1. 修复了每小时天气预报Card无法显示的问题
2. 提示: 若在 `App.g.i.cs` 文件中触发了下述代码，可尝试根据以下方式解决.
   ```csharp
   #if DEBUG && !DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION
            UnhandledException += (sender, e) =>
            {
                if (global::System.Diagnostics.Debugger.IsAttached) global::System.Diagnostics.Debugger.Break();
            };
   #endif
   ```
   1. 在 Visual Studio 菜单栏中，选中 **工具** - **选项** - **调试**，取消勾选 **启用“仅我的代码”**
   2. 在 **调试** - **窗口** - **异常设置** 中，勾选 ***Common Language Runtime Exceptions***
   3. 重新运行项目，即可在异常发生时观察到异常的具体信息

### 2024-10-24

1. 初始上传项目
2. 已知问题：每小时天气预报Card无法显示(Fixed)