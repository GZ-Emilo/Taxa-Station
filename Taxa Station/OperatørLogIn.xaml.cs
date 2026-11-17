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
    /// Interaction logic for OperatørLogIn.xaml
    /// </summary>
    public partial class OperatørLogIn : Window
    {
        public OperatørLogIn()
        {
            InitializeComponent();
        }

        private void tilbage_Click(object sender, RoutedEventArgs e)
        {
            logIn logInSide = new logIn();
            logInSide.Show();
            this.Close();
        }

        private void OPLogIn_Click(object sender, RoutedEventArgs e)
        {
            OperatørSide OPSide = new OperatørSide();
            OPSide.Show();
            this.Close();
        }
    }
}
