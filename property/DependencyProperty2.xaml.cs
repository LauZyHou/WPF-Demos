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
    /// DependencyProperty2.xaml 的交互逻辑
    /// 一般情况下数据来源是业务逻辑层对象，而目标是UI层控件。这里为了展示依赖属性将其反过来。
    /// </summary>
    public partial class DependencyProperty2 : Window
    {
        Student stu;
        /*
        public DependencyProperty2()
        {
            InitializeComponent();
            stu = new Student();
            Binding binding = new Binding("Text") { Source = textBox1 };
            //将stu对象的Student.NameProperty依赖属性对应的CLR属性借助binding绑定在textBox1上
            BindingOperations.SetBinding(stu, Student.NameProperty, binding);
            //同时还绑定给textBxox2
            textBox2.SetBinding(TextBox.TextProperty, binding);
        }

        //按下按钮时，显示Student的Name的值
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu.GetValue(Student.NameProperty).ToString());
            //实际上，在键入变化时stu的Name和TextBox2的Text都在实时发生更新
            //只不过点下按钮才把stu的Name显示了出来
        }
        */
        public DependencyProperty2()
        {
            InitializeComponent();
            stu = new Student();
            //这里演示Binding链，textBox1.Text->stu.Name->textBox2.Text
            stu.SetBinding(Student.NameProperty, new Binding("Text") { Source = textBox1 });
            textBox2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu });
        }

        //按下按钮时，显示Student的Name的值
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu.Name);
        }
    }
}
