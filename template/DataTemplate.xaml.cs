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
using WPF_Demos.user_control;

namespace WPF_Demos.template
{
    /// <summary>
    /// DataTemplate.xaml 的交互逻辑
    /// </summary>
    public partial class DataTemplate : Window
    {
        public DataTemplate()
        {
            InitializeComponent();
            InitialCarList();
        }
        
        private void InitialCarList()
        {
            List<Car> carList = new List<Car>()
            {
                new Car(){Automaker="dazhong",Name="polo",Year="1990",TopSpeed="340"},
                new Car(){Automaker="baoma",Name="宝马X2",Year="2001",TopSpeed="353"},
                new Car(){Automaker="biaozhi",Name="标志508L",Year="2003",TopSpeed="325"},
                new Car(){Automaker="sikeda",Name="晶悦",Year="2008",TopSpeed="356"}
            };
            //填充数据源
            this.listBoxCars.ItemsSource = carList;
        }
    }
}
