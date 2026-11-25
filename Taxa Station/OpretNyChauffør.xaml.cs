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
    /// Interaction logic for OpretNyChauffør.xaml
    /// </summary>
    public partial class OpretNyChauffør : Window
    {
        List<Taxa> taxalist;
        public OpretNyChauffør(List<Taxa> list)
        {
            InitializeComponent();
            taxalist = list;
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

        private void Tilbage_Click(object sender, RoutedEventArgs e)
        {
            OperatørSide opSide = new OperatørSide(taxalist);
            opSide.Show();
            this.Close();
        }

        private void OpretChauf_Click(object sender, RoutedEventArgs e)
        {
            Taxa taxa = new Taxa();
            taxa.chauffør = new Chauffør();
            taxa.chauffør.navn = nyNavn.Text;
            taxa.chauffør.status = "Fri";
            taxa.chauffør.bn = nyBN.Text;
            taxa.chauffør.pass = nyAdg.Text;
            taxalist.Add(taxa);
            gemList();
            TaxaStatus.Items.Add(taxa.chauffør);
            TaxaStatus.Items.Refresh();
            nyNavn.Clear();
            nyBN.Clear();
            nyAdg.Clear();
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
