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
        private List<Chauffør> chaufførlist;
        string ledig = "Ledig";
        string utilgængelig = "Utilgængelig";
        string pause = "På pause";
        string fri = "Holder fri";
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
                if (list[i].status == ledig)
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
            Chauffør valgt =(Chauffør) TaxaStatus.SelectedItem;
            ValgtTaxa.Items.Add(valgt.navn);
        }

        private void ValgtTaxa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void bestilKnap_Click(object sender, RoutedEventArgs e)
        {
            Chauffør valgt = (Chauffør)ValgtTaxa.ItemsSource;
            TaxaStatus.Items.Remove(valgt);
            ValgtTaxa.Items.Clear();
            afhentningssted.Clear();
        }
    }
}
