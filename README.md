# WPF-Demos

WPF编程实例，基于.Net Core 3.0。

## 使用

从Visual Studio打开，修改App.xaml中的`StartupUri`以启动不同的编程实例。

## 目录

### control 控件

- ContentControl

派生自ContentControl类的（Button控件）小demo，此类控件只能由单一元素充当其内容。

- HeaderedContentControl

派生自HeaderedContentControl类的（GroupBox控件）小demo，此类控件只能由单一元素充当其内容，同时有一个标题。

- ItemsControl

派生自ItemsControl类的（ListBox控件）小demo，此类控件用于显示列表化的数据，每种ItemsControl都有自己的条目容器（如ListBox控件的条目容器是ListBoxItem）。

### layout 布局

- Grid

网格布局。

- GridSplitter

使用Grid布局实现可拖拽分隔栏。

- Canvas

画布，绝对坐标定位。

- DockPanel

泊靠式面板，内部元素可选择泊靠方向。

- StackPanel

栈式面板，可水平或垂直排列元素，并能在移除元素后自动移动补充位置。

- WrapPanel

自动折行面板，在内部元素排满一行后自动换行。

### binding 数据绑定

简单说，Source指定要绑定的源，Path指定具体要绑定的属性。

- SimpleBinding

最基本的数据绑定，将同namespace下`Student`类的一个实例的`Name`字段绑定到了TextBox的内容上。

- ControlAsSource

把控件作为Source绑定到控件上，且使用了标记扩展语法，这里是将Slider滑动条的值绑定到了TextBox的内容上。

- BindingMode

要控制数据流向，使用Binding的Mode参数，可以取值`TwoWay/OneWay/OnTime/OneWayToSource/Default`。默认取`Default`时会根据目标实际情况，如ControlAsSource的例子中，因为TextBox.Text是可编辑的，所以就使用了双向模式。本例中`Mode=OneWay`即使用了单向模式，改变文本框的值无法改变拖拽条的位置。

- BindingUpdateSourceTrigger

要控制更新数据源数据的触发时机，使用Binding的UpdateSourceTrigger参数，可以取值`PropertyChanged/LostFocus/Explicit/Default`。默认取`Default`时会根据目标实际情况，如ControlAsSource的例子中，对TextBox.Text使用了`LostFocus`的行为。本例中`UpdateSourceTrigger=PropertyChanged`即在数据改变时实时更新数据源，不再是失去焦点时才更新了。

- BindingPath

Binding的Path属性的特殊使用。本例中绑定为了TextBox内容的长度，以及TextBox内容中的第4个元素。

- NoSource

不为Binding设置Source时，会沿着UI元素树一路向树的根部找过去（实际上是DataContext作为依赖属性向内传递），直到找到一个结点的DataContent（每个WPF控件都有DataContent属性）具有Path所指定的属性。本例中使用为根StackPanel设置了用于绑定的DataContent。

- NoPath

不为Binding指定Path，用于Binding源本身就是数据，不需要Path指定其字段。

- UseItemsSource

使用集合对象作为列表控件的ItemsSource。

### user_control 用户控件

- UserControl

使用了CarDetailView来展示左侧的汽车详细信息，使用CarListItemView来展示右侧的汽车选择列表。

### template 模板

- DataTemplate

数据模板，在xaml的开头导入了resource_dic下的两个数据字典，两个数据字典中分别定义了数据模板（也可以定义到一起去），并且使用到了converter下的UCConverter中的两个转换类。在书写数据模板时无法直观看到用户的控件的样子，可以先写好用户控件，然后再拷贝到数据模板中来。

- control_tmp

控件模板的两个例子。第一个是为TextBox设置圆角，第二个是为ItemsControl的ItemsPanel使用ItemsPanelTemplate设置控件模板以让ListBox内部元素横向排列。

### sample 样例

- use_tab_control

使用选项卡的样例，参照[此篇](https://www.cnblogs.com/lk-kk/p/4609026.html)。

### property 属性

- DependencyProperty1,2

使用依赖属性的简单示例，其中`2`还展示了Binding链以及依赖对象和依赖属性经封装后的简单用法。Student类是一个标准的依赖对象。
每个DependencyObject实例都自带一个EffectiveValueEntry类型数组，当某个依赖属性被读取时，就会去这个数组中去检索值。
被static关键字修饰的依赖属性对象其作用是来检索真正的属性值而不是存储值。

- AttachProperty

附加属性的简单示例。附加属性是特殊的依赖属性，只是用于在数组里检索值的依赖属性保存在宿主里。

- APBinding

附加属性绑定在其它对象上的示例。这里是矩形在Canvas里有了Left和Top两个源自Canvas的附加属性，将其绑定到了两个Slider的Value上。

### x_namespace x命名空间

x命名空间中提供的是在解析和编译XAML中的设置，即程序员和XAML编译器沟通的工具。

#### Attribute

Attribute是语言层面的，给编译器看的东西。

- x:Class

用于告诉XAML编译器将XAML标签的编译结果与后台代码中指定的类合并。

- x:ClassModifier

用于告诉XAML编译由标签生成的类的访问级别,和x:Class指定的类的访问级别要一致。

- x:Name

XAML默认只声明对象，不创建引用变量。`x:Name`就是显式地告诉XAML编译器为这个对象声明引用变量。
当一个元素有`Name`属性时（是`FrameworkElement`实例），和`x:Name`是一样的效果。没有的时候就只能用`x:Name`了。

- x:FieldModifier

用于控制XAML窗体中元素的访问级别，默认情况下是internal。当需要从一个程序集访问另一个程序集窗体中的元素时，就要设置为public。

- x:Key和x:Shared

`x:Key`用于为资源贴上用于检索的索引，常用在资源字典中。
当设置了`x:key`，方可使用`x:Shared`设置每次取出的是同一个对象还是新副本，默认是true，即同一个对象。

#### MarkupExtension

标记扩展实际就是一些MarkupExtension类的直接或间接派生类。

- x:Type

`x:Type`用于XAML元素里那些需要传入数据类型的参数。
这个例子中是自己继承了Button，然后设定一个UserWindowType参数传入窗口类型，点击按钮时就创建一个该类型的窗口并打开。

- x:Null

当一个属性具有默认值，而在使用时要消除这个默认值时，使用`x:Null`设置值。

- x:Array

`x:Array`的作用是通过它的Items属性向使用者暴露一个类型已知的ArrayList实例。
这个标记扩展比较特殊，要用其标签声明形式，然后在子元素里添加元素。在解析`<x:Array>`标签的时候编译器会生成调用AddChild方法的代码，将其子元素添加到`x:Array`实例的Items里。

- x:Static

`x:Static`用于在XAML文档中使用数据类型的Static成员。
这个例子中是在C#文件的类中设置了一个static字段，一个static属性，然后在XAML文件中取出它们。

## 鸣谢

以下是完成本仓库中示例所采用的学习资源。

- 刘铁猛：《深入浅出WPF》

