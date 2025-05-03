using System;
using System.Windows;
using System.Windows.Controls;

namespace task
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();

            LoginButton.Foreground = System.Windows.Media.Brushes.BlueViolet;
            LoginButton.Background = System.Windows.Media.Brushes.LightGray;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckMark(UsernameTextBox) | CheckMark(PasswordTextBox))
            {
                ErrorMessageTextBlock.Text = "Будь ласка, заповніть усі поля.";
                ErrorMessageTextBlock.Foreground = System.Windows.Media.Brushes.Red;
            } else
            {
                ErrorMessageTextBlock.Text = "Вхід успішний!";
                ErrorMessageTextBlock.Foreground = System.Windows.Media.Brushes.Green;
            }

            ErrorMessageTextBlock.Visibility = Visibility.Visible;

            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (s, args) =>
            {
                ErrorMessageTextBlock.Visibility = Visibility.Hidden;
                timer.Stop();
            };
            timer.Start();
        }

        private bool CheckMark(Control c)
        {
            bool result = false;
            string txt = c is TextBox t ? t.Text :
                         c is PasswordBox p ? p.Password :
                         string.Empty;

            if (string.IsNullOrEmpty(txt))
            {
                var col = c.BorderBrush;

                c.BorderBrush = System.Windows.Media.Brushes.Red;
                result = true;

                var timer = new System.Windows.Threading.DispatcherTimer();
                timer.Interval = TimeSpan.FromSeconds(2);
                timer.Tick += (s, args) =>
                {
                    c.BorderBrush = col;
                    timer.Stop();
                };
                timer.Start();
            }

            return result;
        }
    }
}
