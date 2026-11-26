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
        List<Taxa> taxalist;
        public OperatørSide(List<Taxa> loginlist)
        {
            InitializeComponent();
            taxalist = loginlist;
            tilføjTilListe(taxalist);
        }

        private void tilføjTilListe(List<Taxa> list)
        {
            int i = 0;
            while (i < list.Count)
            {
                TaxaStatus.Items.Add(list[i].chauffør);
                i++;
            }
        }

        private void OPLogUd_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpretNyChauffør opretNy = new OpretNyChauffør(taxalist);
            opretNy.Show();
            this.Close();
        }

        private void sletChauffør_Click(object sender, RoutedEventArgs e)
        {
            Taxa valgt = new Taxa();
            valgt.chauffør =(Chauffør) TaxaStatus.SelectedItem;
            int i = 0;
            while (i < taxalist.Count)
            {
                if (valgt.chauffør.bn == taxalist[i].chauffør.bn && valgt.chauffør.pass == taxalist[i].chauffør.pass)
                {
                    TaxaStatus.Items.Remove(taxalist[i].chauffør);
                    taxalist.Remove(taxalist[i]);
                    TaxaStatus.UnselectAll();
                    gemList();
                    TaxaStatus.Items.Refresh();
                }
                i++;
            }
        }

        void gemList()
        {
            string[] gem = new string[taxalist.Count * 4];
            int arrayPos = 0;
            int p = 0;


            while (p < taxalist.Count)
            {
                gem[arrayPos] = taxalist[p].chauffør.navn;
                arrayPos++;
                p++;

            }
            p = 0;

            while (p < taxalist.Count)
            {
                gem[arrayPos] = taxalist[p].chauffør.status;
                arrayPos++;
                p++;
            }
            p = 0;

            while (p < taxalist.Count)
            {
                gem[arrayPos] = taxalist[p].chauffør.bn;
                arrayPos++;
                p++;
            }
            p = 0;

            while (p < taxalist.Count)
            {
                gem[arrayPos] = taxalist[p].chauffør.pass;
                arrayPos++;
                p++;
            }

            System.IO.File.WriteAllLines(@"gem1.txt", gem);
        }
    }
}
