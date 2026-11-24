using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for OperatørSide.xaml
    /// </summary>
    public partial class OperatørSide : Window
    {
        List<Taxa> loginlist;
        public OperatørSide(List<Taxa> loginlist)
        {
            InitializeComponent();
            this.loginlist = loginlist;
            skabListe();
        }

        public void skabListe()
        {
            int i = 0;
            while (i < loginlist.Count)
            {
                OperatørLog.Items.Add(loginlist[i].chauffør);
                i++;
            }
        }
        private void OPLogUd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }

        private void OperatørLog_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
