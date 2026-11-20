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
        List<Chauffør> chaufførlist;
        Chauffør valgt;
        public BestilTaxa(List<Chauffør> list)
        {
            InitializeComponent();
            chaufførlist = list;
            tilføjTilListe(chaufførlist);
        }
        private void tilføjTilListe(List<Chauffør> list)
        {
            int i = 0;
            while (i < list.Count)
            {
                if (list[i].status == "Ledig")
                {
                    TaxaStatus.Items.Add(list[i]);
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
            while (i < chaufførlist.Count)
            {
                if (valgt == chaufførlist[i])
                {
                    chaufførlist[i].status = "Utilgængelig";
                }
                i++;
            }
            ValgtTaxa.Items.Clear();
            afhentningssted.Clear();
            TaxaStatus.Items.Clear();
            tilføjTilListe(chaufførlist);
        }
    }
}
