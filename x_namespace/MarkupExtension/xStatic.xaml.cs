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
    /// xStatic.xaml 的交互逻辑
    /// </summary>
    public partial class xStatic : Window
    {
        //static字段
        public static string windowTitle = "我是一个static字段";
        //static属性
        public static string ShowText { get { return "我是一个static属性get出来的值"; } }
        public xStatic()
        {
            InitializeComponent();
        }
    }
}
