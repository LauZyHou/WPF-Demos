# WPF-Demos

WPF���ʵ��������.Net Core 3.0��

## ʹ��

��Visual Studio�򿪣��޸�App.xaml�е�`StartupUri`��������ͬ�ı��ʵ����

## Ŀ¼

### control �ؼ�

- ContentControl

������ContentControl��ģ�Button�ؼ���Сdemo������ؼ�ֻ���ɵ�һԪ�س䵱�����ݡ�

- HeaderedContentControl

������HeaderedContentControl��ģ�GroupBox�ؼ���Сdemo������ؼ�ֻ���ɵ�һԪ�س䵱�����ݣ�ͬʱ��һ�����⡣

- ItemsControl

������ItemsControl��ģ�ListBox�ؼ���Сdemo������ؼ�������ʾ�б������ݣ�ÿ��ItemsControl�����Լ�����Ŀ��������ListBox�ؼ�����Ŀ������ListBoxItem����

### layout ����

- Grid

���񲼾֡�

- GridSplitter

ʹ��Grid����ʵ�ֿ���ק�ָ�����

- Canvas

�������������궨λ��

- DockPanel

����ʽ��壬�ڲ�Ԫ�ؿ�ѡ�񲴿�����

- StackPanel

ջʽ��壬��ˮƽ��ֱ����Ԫ�أ��������Ƴ�Ԫ�غ��Զ��ƶ�����λ�á�

- WrapPanel

�Զ�������壬���ڲ�Ԫ������һ�к��Զ����С�

### binding ���ݰ�

��˵��Sourceָ��Ҫ�󶨵�Դ��Pathָ������Ҫ�󶨵����ԡ�

- SimpleBinding

����������ݰ󶨣���ͬnamespace��`Student`���һ��ʵ����`Name`�ֶΰ󶨵���TextBox�������ϡ�

- ControlAsSource

�ѿؼ���ΪSource�󶨵��ؼ��ϣ���ʹ���˱����չ�﷨�������ǽ�Slider��������ֵ�󶨵���TextBox�������ϡ�

- BindingMode

Ҫ������������ʹ��Binding��Mode����������ȡֵ`TwoWay/OneWay/OnTime/OneWayToSource/Default`��Ĭ��ȡ`Default`ʱ�����Ŀ��ʵ���������ControlAsSource�������У���ΪTextBox.Text�ǿɱ༭�ģ����Ծ�ʹ����˫��ģʽ��������`Mode=OneWay`��ʹ���˵���ģʽ���ı��ı����ֵ�޷��ı���ק����λ�á�

- BindingUpdateSourceTrigger

Ҫ���Ƹ�������Դ���ݵĴ���ʱ����ʹ��Binding��UpdateSourceTrigger����������ȡֵ`PropertyChanged/LostFocus/Explicit/Default`��Ĭ��ȡ`Default`ʱ�����Ŀ��ʵ���������ControlAsSource�������У���TextBox.Textʹ����`LostFocus`����Ϊ��������`UpdateSourceTrigger=PropertyChanged`�������ݸı�ʱʵʱ��������Դ��������ʧȥ����ʱ�Ÿ����ˡ�

- BindingPath

Binding��Path���Ե�����ʹ�á������а�Ϊ��TextBox���ݵĳ��ȣ��Լ�TextBox�����еĵ�4��Ԫ�ء�

- NoSource

��ΪBinding����Sourceʱ��������UIԪ����һ·�����ĸ����ҹ�ȥ��ʵ������DataContext��Ϊ�����������ڴ��ݣ���ֱ���ҵ�һ������DataContent��ÿ��WPF�ؼ�����DataContent���ԣ�����Path��ָ�������ԡ�������ʹ��Ϊ��StackPanel���������ڰ󶨵�DataContent��

- NoPath

��ΪBindingָ��Path������BindingԴ����������ݣ�����ҪPathָ�����ֶΡ�

- UseItemsSource

ʹ�ü��϶�����Ϊ�б�ؼ���ItemsSource��

### user_control �û��ؼ�

- UserControl

ʹ����CarDetailView��չʾ����������ϸ��Ϣ��ʹ��CarListItemView��չʾ�Ҳ������ѡ���б�

### template ģ��

- DataTemplate

����ģ�壬��xaml�Ŀ�ͷ������resource_dic�µ����������ֵ䣬���������ֵ��зֱ���������ģ�壨Ҳ���Զ��嵽һ��ȥ��������ʹ�õ���converter�µ�UCConverter�е�����ת���ࡣ����д����ģ��ʱ�޷�ֱ�ۿ����û��Ŀؼ������ӣ�������д���û��ؼ���Ȼ���ٿ���������ģ��������

- control_tmp

�ؼ�ģ����������ӡ���һ����ΪTextBox����Բ�ǣ��ڶ�����ΪItemsControl��ItemsPanelʹ��ItemsPanelTemplate���ÿؼ�ģ������ListBox�ڲ�Ԫ�غ������С�

### sample ����

- use_tab_control

ʹ��ѡ�������������[��ƪ](https://www.cnblogs.com/lk-kk/p/4609026.html)��

### property ����

- DependencyProperty1,2

ʹ���������Եļ�ʾ��������`2`��չʾ��Binding���Լ�����������������Ծ���װ��ļ��÷���Student����һ����׼����������
ÿ��DependencyObjectʵ�����Դ�һ��EffectiveValueEntry�������飬��ĳ���������Ա���ȡʱ���ͻ�ȥ���������ȥ����ֵ��
��static�ؼ������ε��������Զ���������������������������ֵ�����Ǵ洢ֵ��

- AttachProperty

�������Եļ�ʾ��������������������������ԣ�ֻ�����������������ֵ���������Ա����������

- APBinding

�������԰������������ϵ�ʾ���������Ǿ�����Canvas������Left��Top����Դ��Canvas�ĸ������ԣ�����󶨵�������Slider��Value�ϡ�

### x_namespace x�����ռ�

x�����ռ����ṩ�����ڽ����ͱ���XAML�е����ã�������Ա��XAML��������ͨ�Ĺ��ߡ�

#### Attribute

Attribute�����Բ���ģ������������Ķ�����

- x:Class

���ڸ���XAML��������XAML��ǩ�ı��������̨������ָ������ϲ���

- x:ClassModifier

���ڸ���XAML�����ɱ�ǩ���ɵ���ķ��ʼ���,��x:Classָ������ķ��ʼ���Ҫһ�¡�

- x:Name

XAMLĬ��ֻ�������󣬲��������ñ�����`x:Name`������ʽ�ظ���XAML������Ϊ��������������ñ�����
��һ��Ԫ����`Name`����ʱ����`FrameworkElement`ʵ��������`x:Name`��һ����Ч����û�е�ʱ���ֻ����`x:Name`�ˡ�

- x:FieldModifier

���ڿ���XAML������Ԫ�صķ��ʼ���Ĭ���������internal������Ҫ��һ�����򼯷�����һ�����򼯴����е�Ԫ��ʱ����Ҫ����Ϊpublic��

- x:Key��x:Shared

`x:Key`����Ϊ��Դ�������ڼ�������������������Դ�ֵ��С�
��������`x:key`������ʹ��`x:Shared`����ÿ��ȡ������ͬһ���������¸�����Ĭ����true����ͬһ������

#### MarkupExtension

�����չʵ�ʾ���һЩMarkupExtension���ֱ�ӻ��������ࡣ

- x:Type

`x:Type`����XAMLԪ������Щ��Ҫ�����������͵Ĳ�����
������������Լ��̳���Button��Ȼ���趨һ��UserWindowType�������봰�����ͣ������ťʱ�ʹ���һ�������͵Ĵ��ڲ��򿪡�

- x:Null

��һ�����Ծ���Ĭ��ֵ������ʹ��ʱҪ�������Ĭ��ֵʱ��ʹ��`x:Null`����ֵ��

- x:Array

`x:Array`��������ͨ������Items������ʹ���߱�¶һ��������֪��ArrayListʵ����
��������չ�Ƚ����⣬Ҫ�����ǩ������ʽ��Ȼ������Ԫ�������Ԫ�ء��ڽ���`<x:Array>`��ǩ��ʱ������������ɵ���AddChild�����Ĵ��룬������Ԫ����ӵ�`x:Array`ʵ����Items�

- x:Static

`x:Static`������XAML�ĵ���ʹ���������͵�Static��Ա��
�������������C#�ļ�������������һ��static�ֶΣ�һ��static���ԣ�Ȼ����XAML�ļ���ȡ�����ǡ�

## ��л

��������ɱ��ֿ���ʾ�������õ�ѧϰ��Դ��

- �����ͣ�������ǳ��WPF��

