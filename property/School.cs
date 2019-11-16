using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace WPF_Demos.property
{
    //学校类，它有附加属性年级
    class School : DependencyObject
    {
        //snippet propa
        //附加属性Grade

        public static int GetGrade(DependencyObject obj)
        {
            return (int)obj.GetValue(GradeProperty);
        }

        public static void SetGrade(DependencyObject obj, int value)
        {
            obj.SetValue(GradeProperty, value);
        }

        // Using a DependencyProperty as the backing store for Grade.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GradeProperty =
            DependencyProperty.RegisterAttached("Grade", typeof(int), typeof(School), new PropertyMetadata(0));

    }
}
