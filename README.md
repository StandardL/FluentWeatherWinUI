# FluentWeather

## ������־

### 2024-10-24 (Updated)
1. �޸���ÿСʱ����Ԥ��Card�޷���ʾ������
2. ��ʾ: ���� `App.g.i.cs` �ļ��д������������룬�ɳ��Ը������·�ʽ���.
   ```csharp
   #if DEBUG && !DISABLE_XAML_GENERATED_BREAK_ON_UNHANDLED_EXCEPTION
            UnhandledException += (sender, e) =>
            {
                if (global::System.Diagnostics.Debugger.IsAttached) global::System.Diagnostics.Debugger.Break();
            };
   #endif
   ```
   1. �� Visual Studio �˵����У�ѡ�� **����** - **ѡ��** - **����**��ȡ����ѡ **���á����ҵĴ��롱**
   2. �� **����** - **����** - **�쳣����** �У���ѡ ***Common Language Runtime Exceptions***
   3. ����������Ŀ���������쳣����ʱ�۲쵽�쳣�ľ�����Ϣ

### 2024-10-24

1. ��ʼ�ϴ���Ŀ
2. ��֪���⣺ÿСʱ����Ԥ��Card�޷���ʾ(Fixed)