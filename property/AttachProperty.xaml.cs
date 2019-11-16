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
    /// AttachProperty.xaml 的交互逻辑
    /// </summary>
    public partial class AttachProperty : Window
    {
        public AttachProperty()
        {
            InitializeComponent();
        }

        //点击按钮
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //人类在学校里就被附加上年级这个属性
            Human human = new Human();
            School.SetGrade(human, 6);//为human设置Grade=6
            int grade = School.GetGrade(human);//获取到Grade
            MessageBox.Show(grade.ToString());
        }
    }
}
