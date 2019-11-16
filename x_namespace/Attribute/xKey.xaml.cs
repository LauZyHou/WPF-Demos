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

namespace WPF_Demos.x_namespace.Attribute
{
    /// <summary>
    /// xKey.xaml 的交互逻辑
    /// </summary>
    public partial class xKey : Window
    {
        public xKey()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //在C#中访问XAML中定义的资源字典
            string str = this.FindResource("myString") as string;
            this.textBox1.Text = str;
        }
    }
}
