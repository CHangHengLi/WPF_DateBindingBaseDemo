using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfDataBindingDemo.Views
{
    /// <summary>
    /// UpdateSourceTriggerDemo.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateSourceTriggerDemo : Page
    {
        public UpdateSourceTriggerDemo()
        {
            InitializeComponent();
        }
        
        // 显式更新绑定源
        private void UpdateExplicit_Click(object sender, RoutedEventArgs e)
        {
            // 获取TextBox的绑定表达式并手动更新源
            BindingExpression binding = explicitTextBox.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }
    }
} 