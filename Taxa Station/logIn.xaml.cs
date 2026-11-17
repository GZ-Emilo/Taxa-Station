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
        public logIn()
        {
            InitializeComponent();
        }

        private void tilbage1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChaufførLogIn chaufførlogin = new ChaufførLogIn();
            chaufførlogin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OperatørLogIn OPLogIn = new OperatørLogIn();
            OPLogIn.Show();
            this.Close();
        }
    }
}
