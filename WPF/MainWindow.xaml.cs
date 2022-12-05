using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TestWin.Title = "TestWindow";

            //btnShowAlert.Click += btnShowAlert_Click; // делегат

            //Button btn = new Button();
            //btn.Content = "Button";
            //btn.Height = 50;
            //btn.Width = 50;

            //TestWin.Content = btn;
        }

        private void btnShowAlert_Click(object sender, RoutedEventArgs e)  //sender - с кем происходит  e - что происходит
        {
            Button btn = (Button)sender;

            MessageBox.Show("Work - "+DateTime.Now);
        }

        private void btnSentMsg_Click(object sender, RoutedEventArgs e)
        {
            bool result = false;
            lblMessage.Content = Helper.SentMsg(tbxTo.Text, tbxSubject.Text, tbxBody.Text, out result);

            if (!result)
            {
                lblMessage.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                lblMessage.Foreground = new SolidColorBrush(Colors.Green);
            }
        }
    }
}
