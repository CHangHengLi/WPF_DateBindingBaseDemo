using System.Windows;
using WpfDataBindingDemo.Views;

namespace WpfDataBindingDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // 默认显示基本数据绑定示例
        ShowPersonDemo();
    }
    
    // 基本数据绑定示例
    private void btnPersonDemo_Click(object sender, RoutedEventArgs e)
    {
        ShowPersonDemo();
    }
    
    // ElementName绑定示例
    private void btnElementNameDemo_Click(object sender, RoutedEventArgs e)
    {
        mainFrame.Navigate(new ElementNameBindingDemo());
    }
    
    // RelativeSource绑定示例
    private void btnRelativeSourceDemo_Click(object sender, RoutedEventArgs e)
    {
        mainFrame.Navigate(new RelativeSourceBindingDemo());
    }
    
    // UpdateSourceTrigger示例
    private void btnUpdateSourceTriggerDemo_Click(object sender, RoutedEventArgs e)
    {
        mainFrame.Navigate(new UpdateSourceTriggerDemo());
    }
    
    // 显示基本数据绑定示例
    private void ShowPersonDemo()
    {
        // 创建一个包含基本人员信息绑定的页面
        PersonDemoPage personPage = new PersonDemoPage();
        mainFrame.Navigate(personPage);
    }
}