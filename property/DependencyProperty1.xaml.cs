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

namespace WPF_Demos.property
{
    /// <summary>
    /// DependencyProperty1.xaml 的交互逻辑
    /// </summary>
    public partial class DependencyProperty1 : Window
    {
        public DependencyProperty1()
        {
            InitializeComponent();
        }

        //按下OK
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            //get和set都要传入Student.NameProperty即依赖属性这个静态字段，这样才能表示操作的是底层哪个CLR属性的值
            //为依赖对象设置依赖属性所表达的CLR属性的值
            stu.SetValue(Student.NameProperty, this.textBox1.Text);
            //取出依赖属性所表达的CLR属性的值，这里返回的object要强制转换一下
            textBox2.Text = (string)stu.GetValue(Student.NameProperty);
        }
    }
}
