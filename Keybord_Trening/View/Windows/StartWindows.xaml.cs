using Keybord_Trening.View.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Keybord_Trening.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для StartWindows.xaml
    /// </summary>
    public partial class StartWindows : Window
    {
        public StartWindows()
        {
            InitializeComponent();
            MainFrame.Navigate(new StartPage());
        }


        private void WindowMenuGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove(); // Перемещение окна
            if (e.ClickCount==2 && WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else if (e.ClickCount == 2 && WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void closeAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); //Полностью убивает меня
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LoginPage());
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RegistrationPage());
        }

        private void Trainer_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TraningPage());
        }

        private void TrainingBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TrainerRezultPage());
        }

        private void Obychenie_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProfilePageWin());
        }

        private void OpenProFill_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hyperlink123_Click(object sender, RoutedEventArgs e)
        {
            //Process.Start("www.nookery.ru"); //открытие ссылки в браузере
        }

        private void Reintingbtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new RatingPage());
        }
    }
}
