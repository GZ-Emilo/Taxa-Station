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
    /// Interaction logic for BestilTaxa.xaml
    /// </summary>
    public partial class BestilTaxa : Window
    {
        public BestilTaxa(List<Chauffør> list)
        {
            InitializeComponent();

            TaxaStatus.ItemsSource = list;
        }
       
        private void Tilbage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow tilbage = new MainWindow();
            tilbage.Show();
            this.Close();
        }
        private void TaxaStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Taxa vis = (Taxa)TaxaStatus.SelectedItem;
            if (vis != null && vis.mand.status == "Tilgængelig")
            {
                TaxaStatus.Items.Add(vis.mand.navn + " : " + vis.mand.status);
            }
        }

        private void valgAfTaxaKnap_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Taxa vis = (Taxa)TaxaStatus.SelectedItem;
            //if (vis != null && vis.mand.status == "Tilgængelig")
            //{
            //    valgAfTaxaKnap.Items.Add(vis.mand.navn + " : " + vis.mand.status);
            //}
        }
    }
}
