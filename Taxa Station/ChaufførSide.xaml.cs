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
    /// Interaction logic for ChaufførSide.xaml
    /// </summary>
    public partial class ChaufførSide : Window
    {
        private List<Taxa> chauflist;
        List<Taxa> chaufLogged;
        public ChaufførSide(List<Taxa> loginlist, List<Taxa> chaufLoggedIn)
        {
            InitializeComponent();
            chauflist = loginlist;
            chaufLogged = chaufLoggedIn;
            skabListe();
        }

        public void skabListe()
        {
            int i = 0;
            while (i < chauflist.Count)
            {
                chaufførListbox.Items.Add(chauflist[i].chauffør);
                i++;
            }
        }
        //test

        private void ChaufLogUd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }

        private void sætLedig_Click(object sender, RoutedEventArgs e)
        {
            chaufLogged[0].chauffør.status = "Ledig";
            int i = 0;
            while (i < chauflist.Count)
            {
                if (chauflist[i].chauffør.bn == chaufLogged[0].chauffør.bn && chauflist[i].chauffør.pass == chaufLogged[0].chauffør.pass)
                {
                    chauflist[i].chauffør.status = chaufLogged[0].chauffør.status;
                }
                i++;
            }
            chaufførListbox.Items.Refresh();
        }
    }
}
