using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
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
    /// Interaction logic for BestilTaxa.xaml
    /// </summary>
    public partial class BestilTaxa : Window
    {
        List<Taxa> taxalist;
        Chauffør valgt;
        public BestilTaxa(List<Taxa> list)
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
                if (list[i].chauffør.status == "Ledig")
                {
                    TaxaStatus.Items.Add(list[i].chauffør);
                }
                i++;
            }
        }

        private void Tilbage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }
        private void TaxaStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ValgtTaxa.Items.Clear();
            valgt = (Chauffør)TaxaStatus.SelectedItem;
            ValgtTaxa.Items.Add(valgt);
        }

        private void ValgtTaxa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bestilKnap_Click(object sender, RoutedEventArgs e)
        {
            Chauffør valgt = (Chauffør)TaxaStatus.SelectedItem;
            int i = 0;
            while (i < taxalist.Count)
            {
                if (valgt == taxalist[i].chauffør)
                {
                    taxalist[i].chauffør.status = "Utilgængelig";
                }
                i++;
            }
            ValgtTaxa.Items.Clear();
            afhentningssted.Clear();
            TaxaStatus.Items.Clear();
            tilføjTilListe(taxalist);
        }
    }
}


