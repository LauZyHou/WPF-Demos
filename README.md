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

## 鸣谢

以下是完成本仓库中示例所采用的学习资源。

- 刘铁猛：《深入浅出WPF》

