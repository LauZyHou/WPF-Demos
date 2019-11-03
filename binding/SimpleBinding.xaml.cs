using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Demos.binding
{
    /// <summary>
    /// SimpleBinding.xaml 的交互逻辑
    /// </summary>
    public partial class SimpleBinding : Window
    {
        Student stu;//用于双向数据绑定的具体对象,也即绑定数据的载体

        //在构造器里进行数据绑定
        public SimpleBinding()
        {
            InitializeComponent();

            stu = new Student();

            /*
            //准备Binding对象
            Binding binding = new Binding();
            //绑定的是stu这个对象的Name属性
            binding.Source = stu;
            binding.Path = new PropertyPath("Name");
            */

            //也可以使用下面的方式创建binding对象,构造时传入Path,构造后传入Source
            Binding binding = new Binding("Name")
            {
                Source = stu
            };

            /*
            //将控件的属性,用binding对象,连接到数据对象的属性上
            //[传入参数:控件,控件属性,binding对象]
            BindingOperations.SetBinding(this.textBox1, TextBox.TextProperty, binding);
            */

            //也可以使用下面的方式,是TextBox对SetBinding的封装
            //[传入参数:控件属性,binding对象]
            this.textBox1.SetBinding(TextBox.TextProperty, binding);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stu.Name += "6";//每次点击按钮,让stu的Name属性后面接一个6,而这里的数据变化刷新到TextBox上
        }
    }
}
