using System.Windows;


namespace example2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void customControl_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "You have just click your custom control";
        }
    }
}
