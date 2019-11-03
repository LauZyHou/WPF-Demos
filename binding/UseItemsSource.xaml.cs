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
    /// UseItemsSource.xaml 的交互逻辑
    /// </summary>
    public partial class UseItemsSource : Window
    {
        List<Student2> stuList = null;
        public UseItemsSource()
        {
            InitializeComponent();

            //数据源
            stuList = new List<Student2>()
            {
                new Student2(){Id=0,Name="Tim",Age=29},
                new Student2(){Id=1,Name="Tom",Age=28},
                new Student2(){Id=2,Name="Tony",Age=27}
            };

            //为ListBox控件设置Binding，首先将其ItemsSource属性设置为集合类型的对象
            this.listBoxStudents.ItemsSource = stuList;
            //还要设置其Path为Name属性
            this.listBoxStudents.DisplayMemberPath = "Name";

            //为TextBox控件设置Binding，这里就是绑定到ListBox控件上去
            //在构造时传入Path = "SelectedItem.Id",构造后设置Source为ListBox
            Binding binding = new Binding("SelectedItem.Id") { Source = this.listBoxStudents };
            this.textBoxId.SetBinding(TextBox.TextProperty, binding);
        }
    }
}
