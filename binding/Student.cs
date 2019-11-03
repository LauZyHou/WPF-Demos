using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace WPF_Demos.binding
{
    class Student:INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            //在set方法中(即Name的值变化时)激发PropertyChanged事件
            set 
            {
                name = value;
                if(this.PropertyChanged!=null)
                {
                    //触发事件,告诉Binding名为"Name"的属性发生了值的改变
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
