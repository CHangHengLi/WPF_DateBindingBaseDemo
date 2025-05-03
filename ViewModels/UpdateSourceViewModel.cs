namespace WpfDataBindingDemo.ViewModels
{
    public class UpdateSourceViewModel : ViewModelBase
    {
        // 三种不同绑定方式的文本属性
        private string _defaultText = "默认值 - 输入后点击其他位置";
        public string DefaultText
        {
            get { return _defaultText; }
            set
            {
                if (_defaultText != value)
                {
                    _defaultText = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private string _propertyChangedText = "属性更改值 - 输入时即时更新";
        public string PropertyChangedText
        {
            get { return _propertyChangedText; }
            set
            {
                if (_propertyChangedText != value)
                {
                    _propertyChangedText = value;
                    OnPropertyChanged();
                }
            }
        }
        
        private string _explicitText = "显式值 - 需点击更新按钮";
        public string ExplicitText
        {
            get { return _explicitText; }
            set
            {
                if (_explicitText != value)
                {
                    _explicitText = value;
                    OnPropertyChanged();
                }
            }
        }
    }
} 