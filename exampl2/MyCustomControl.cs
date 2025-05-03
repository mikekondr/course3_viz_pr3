using System.Windows;
using System.Windows.Controls;


namespace example2
{
    public class MyCustomControl : Button
    {
        static MyCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomControl), new FrameworkPropertyMetadata(typeof(MyCustomControl)));
        }
    }
}
