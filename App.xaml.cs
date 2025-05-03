using System.Configuration;
using System.Data;
using System.Windows;
using System.Diagnostics;

namespace WpfDataBindingDemo;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        // 开启绑定调试跟踪
        PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Warning;
    }
}

