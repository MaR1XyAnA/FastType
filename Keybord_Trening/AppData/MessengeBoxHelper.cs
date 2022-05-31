using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Keybord_Trening.AppData
{
    public class MessengeBoxHelper
    {
        public static void ERROR (string text, string title = "ERROR")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public static void Information(string text, string title = "Информация")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public static void Question(string text, string title = "Вопросик")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Question);
        }

        public static void Warning(string text, string title = "Предупреждение")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public static void Test(string text, string title = "Тест")
        {
            MessageBox.Show(text, title, MessageBoxButton.OK);
        }
    }
}
