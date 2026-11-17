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
    /// Interaction logic for ChaufførLogIn.xaml
    /// </summary>
    public partial class ChaufførLogIn : Window
    {
        public ChaufførLogIn()
        {
            InitializeComponent();
        }

        private void tilbage_Click(object sender, RoutedEventArgs e)
        {
            logIn logInSide = new logIn();
            logInSide.Show();
            this.Close();
        }

        private void ChaufLogIn_Click(object sender, RoutedEventArgs e)
        {
            ChaufførSide ChaufSide = new ChaufførSide();
            ChaufSide.Show();
            this.Close();
        }
    }
}
