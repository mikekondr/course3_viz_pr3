using System.Windows;
using System.Windows.Controls;

namespace example1
{
    /// <summary>
    /// Логика взаимодействия для MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "Ви маєте тільки clicked the button";
        }
    }
}
