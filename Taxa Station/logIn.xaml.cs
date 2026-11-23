using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Taxa_Station
{
    /// <summary>
    /// Interaction logic for logIn.xaml
    /// </summary>
    public partial class logIn : Window
    {

        private List<Taxa> loginlist;
        public logIn(List<Taxa> loginlist)
        {
            InitializeComponent();

            this.loginlist = loginlist;
        }

        private void tilbage1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChaufførLogIn chaufførlogin = new ChaufførLogIn(loginlist);
            chaufførlogin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OperatørLogIn OPLogIn = new OperatørLogIn(loginlist);
            OPLogIn.Show();
            this.Close();
        }
    }
}
