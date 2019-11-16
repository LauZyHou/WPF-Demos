using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace WPF_Demos.property
{
    //依赖对象继承DependencyObject，可以在创建时不包含用于存储的空间，只保留借助其它对象或实施分配空间的能力
    class Student : DependencyObject
    {
        //trick:输入propdp双击Tab可以生成依赖属性的snippet(代码模板)，继续按动Tab以修改参数

        //依赖属性是用public static readonly修饰的DependencyProperty对象
        //使用DependencyProperty.Register(名称，存储的值类型，宿主依赖对象的类型)
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Student));

        //添加CLR属性包装一下依赖属性，这样方便调用
        //stu.Name=xxx,yyy=stu.Name
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        //借用FrameworkElement类的SetBinding方法，这样接下来方便本依赖对象Binding到其它数据源上
        public BindingExpressionBase SetBinding(DependencyProperty dp,BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}
