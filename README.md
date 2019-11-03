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

## ��л

��������ɱ��ֿ���ʾ�������õ�ѧϰ��Դ��

- �����ͣ�������ǳ��WPF��

