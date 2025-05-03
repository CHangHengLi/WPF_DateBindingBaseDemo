using WpfDataBindingDemo.Models;

namespace WpfDataBindingDemo.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        private Person _person;

        public PersonViewModel()
        {
            // 初始化模型数据
            _person = new Person
            {
                FirstName = "张",
                LastName = "三",
                Age = 30
            };
        }

        // 公开的属性，用于绑定
        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                if (_person.FirstName != value)
                {
                    _person.FirstName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName)); // 关联属性也需要通知变更
                }
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                if (_person.LastName != value)
                {
                    _person.LastName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public int Age
        {
            get { return _person.Age; }
            set
            {
                if (_person.Age != value)
                {
                    _person.Age = value;
                    OnPropertyChanged();
                }
            }
        }

        // 计算属性示例
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
} 