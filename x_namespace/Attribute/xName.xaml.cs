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

namespace WPF_Demos.x_namespace
{
    /// <summary>
    /// xName.xaml 的交互逻辑
    /// </summary>
    public partial class xName : Window
    {
        public xName()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Name))
                textBox.Text = "No Name!";
            else
                textBox.Text = textBox.Name;
        }
    }
}
