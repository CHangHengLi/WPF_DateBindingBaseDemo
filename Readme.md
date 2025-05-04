# WPF 数据绑定演示程序

这是一个基于.NET Core 8.0的WPF数据绑定演示程序，展示了WPF数据绑定的各种用法和特性。
![image](https://github.com/user-attachments/assets/84d8ecd9-620c-4a44-babb-3036c6d283b1)

## 项目结构

- **Models**: 包含数据模型类
- **ViewModels**: 包含视图模型类，实现了MVVM模式
- **Views**: 包含各种演示数据绑定功能的页面

## 功能演示

本程序包含以下数据绑定示例：

1. **基本数据绑定示例**：展示了双向绑定和计算属性
2. **ElementName绑定示例**：展示了UI元素之间的绑定
3. **RelativeSource绑定示例**：展示了相对元素的绑定
4. **UpdateSourceTrigger示例**：展示了不同的绑定更新触发器

## 运行方式

使用Visual Studio 2022或更高版本打开解决方案文件，然后按F5运行程序。
或者使用命令行：

```
dotnet run
```

## 核心技术

- WPF (Windows Presentation Foundation)
- MVVM (Model-View-ViewModel) 设计模式
- 数据绑定 (Data Binding)
- C# 属性变更通知 
