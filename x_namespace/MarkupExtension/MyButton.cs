using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Demos.x_namespace
{
    class MyButton : Button
    {
        //Type类是所有数据类型在编程方面的抽象
        //只要知道里面存的是数据类型就可以了
        public Type UserWindowType { get; set; }

        //覆写点击方法
        protected override void OnClick()
        {
            base.OnClick();//激发Click事件
            //用这个数据类型创建窗体，并将其显示
            Window win = Activator.CreateInstance(this.UserWindowType) as Window;
            if(win!=null)
            {
                win.ShowDialog();
            }
        }
    }
}
