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

namespace WPF_Demos.sample
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private int i = 0;//定义一个i用来使新造的Item名字不同
        TextBox t;//每造一个新Item 然后将Textbox扔进去

        //[菜单]打开新窗口
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            TabItem ti = new TabItem();//造一个新选项卡
            ti.Header = "新窗口" + (i + 1);//新选项卡的名字
            TabControl1.Items.Add(ti);//将造好的新选项卡扔进TabControl1里
            t = new TextBox();//实体化一个新文本框
            //设置宽高，TextBox来撑开这个TabItem
            t.Width = 562;
            t.Height = 305;
            //下面开始将文本框添加到新造的选项卡中
            ti.Content = t;
            //每造一个新窗口便默认突出显示为新窗口，这里是设置选中项的下标
            TabControl1.SelectedIndex = i + 1;
            //TabControl1.SelectedIndex = TabControl1.Items.Count - 1;
            i++;
            //双击每个选项卡触发的事件
            ti.MouseDoubleClick += ti_MouseDoubleClick;
        }

        //[菜单]退出
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            //退出当前窗体
            this.Close();
        }

        //双击选项卡时，删除当前的选项卡
        private void ti_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TabItem s = (TabItem)sender; //sender代表每个选项卡
            TabControl1.Items.Remove(s);
        }
    }
}
