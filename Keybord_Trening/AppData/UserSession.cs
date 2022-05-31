using Keybord_Trening.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Keybord_Trening.AppData
{
    class UserSession
    {
        #region claccss
        internal static UsersO UserProfiler { get; set; }
        internal static bool IsLoggedIn { get; set; } = false;
        #endregion


        internal static void CheckAutorization(TextBox name, PasswordBox password)
        {
            //try
            //{
            //    UserProfiler = ConnectDb.GetContext().UsersO.FirstOrDefault(a => a.Name == name.Text);
            //    if (UserProfiler != null)
            //    {
            //        if (UserProfiler.Name == name.Text && UserProfiler.Password == password.Password)
            //        {
            //            MessengeBoxHelper.Information("Пользователь авторизирован, удачи)");
            //            IsLoggedIn = true;
            //            return true;
            //        }
            //    }
            //    else
            //    {
            //        if (name.Text == string.Empty || password.Password == string.Empty)
            //        {
            //            MessengeBoxHelper.Warning("Слепой? Поля пустые!!!");
            //        }
            //        else
            //        {
            //            MessengeBoxHelper.ERROR("Пользователь с такими прекрасными данными, к сожилению не найден(((");
            //        }
            //    }
            //}
            //catch (Exception exception)
            //{
            //    MessengeBoxHelper.ERROR(exception);
            //}

            //return false;
        }
        internal static void CheckRegistration(TextBox name, TextBox email, PasswordBox password)
        {
            //Обработка исключений
            UsersO user = new UsersO
            {
                Name = name.Text,
                Email = email.Text,
                Password = password.Password
            };

            ConnectDb.GetContext().UsersO.Add(user);
            ConnectDb.GetContext().SaveChanges();
            MessageBox.Show("Пользователь добавлен");


        }
        internal static void CheckLoginStatys(StackPanel nonLogged, StackPanel Logged)
        {
            nonLogged.Visibility = Visibility.Collapsed;
            Logged.Visibility = Visibility.Visible;
        }

        //Сдесь отсутствует несколько пунктов и немного кода
    }
}
