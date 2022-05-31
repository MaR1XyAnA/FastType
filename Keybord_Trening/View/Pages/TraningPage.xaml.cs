using Keybord_Trening.AppData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Keybord_Trening.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для TraningPage.xaml
    /// </summary>
    /// 
  /* 
    При помоши e можно получить имя этой клавиши
    InputLineTb.Text = e.Key.ToString();
 */
    public partial class TraningPage : Page
    {
        DispatcherTimer timer = null;
        int temp = 0;


        public TraningPage()
        {
            InitializeComponent();

            //Таймер
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;


            InputLineTb.Focus(); //Автофокусеровка на TextBox
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ++temp;
            //throw new NotImplementedException();
        }

        private void Page_PreviewKeyUp(object sender, KeyEventArgs e)
        {

        }

        private void InputLineTb_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            foreach(StackPanel sp in GridKeyBord.Children)
            {
                foreach(Button btn in sp.Children)
                {
                    if(btn.Name == e.Key.ToString())
                    {
                        btn.BorderThickness = new Thickness(3);
                        btn.FontWeight = FontWeights.SemiBold;
                    }
                }
            }

            if (e.Key == Key.Tab || e.Key == Key.Back || e.Key == Key.Left || e.Key == Key.Right || e.Key == Key.Up || e.Key == Key.Down) 
            {
                {
                    e.Handled = true; //Запрет на нажатие клавиш Backspase и стрелочек
                }
            }
            if(e.Key == Key.Space)
            {
                ++InputLineTb.CaretIndex;
            }
        }

        private void InputLineTb_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            foreach (StackPanel sp in GridKeyBord.Children)
            {
                foreach (Button btn in sp.Children)
                {
                    if (btn.Name == e.Key.ToString())
                    {
                        btn.BorderThickness = new Thickness(0);
                        btn.FontWeight = FontWeights.Normal;
                    }
                }
            }
        }



        private void InputLineTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try
            {
                timer.Start();
                // Сравнение вводимого текста
                if (e.Text == InputLineTb.Text.Substring(InputLineTb.CaretIndex, 1))
                {
                    FakeInputLineTb.Text = InputLineTb.Text.Substring(0, ++InputLineTb.CaretIndex);

                    //++trtrtrtrt (Пост)
                    //trtrtrtrt++ (Пре)
                }
            }
            catch
            {
               timer.Stop();
               // MessageBox.Show(TypeQuality.CalculaterSpeed(InputLineTb, temp));
                NavigationService.Navigate(new TrainerRezultPage());

                TrainerRezultPage trainerRezultPage = new TrainerRezultPage();
                trainerRezultPage.Spiwert.Text =  TypeQuality.CalculaterSpeed(InputLineTb, temp);

                //(new TrainerRezultPage());
                //MainFrame.Navigate(new TrainerRezultPage());
            }

        }

    }

}

