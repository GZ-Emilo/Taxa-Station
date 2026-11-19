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
        public BestilTaxa()
        {


            InitializeComponent();
            BestilTaxaer();
        }
        private void BestilTaxaer()
        {
            List<Chauffør> chaufførlist = new List<Chauffør>();

            Taxa kør1 = new Taxa();
            Taxa kør2 = new Taxa();
            Taxa kør3 = new Taxa();
            Taxa kør4 = new Taxa();
            Taxa kør5 = new Taxa();

            kør1.mand = new Chauffør();
            kør2.mand = new Chauffør();
            kør3.mand = new Chauffør();
            kør4.mand = new Chauffør();
            kør5.mand = new Chauffør();

            //Chauffør kør1 = new Chauffør();
            //Chauffør kør2 = new Chauffør();
            //Chauffør kør3 = new Chauffør();
            //Chauffør kør4 = new Chauffør();
            //Chauffør kør5 = new Chauffør();

            kør1.mand.navn = "Povl";
            kør2.mand.navn = "Miriam";
            kør3.mand.navn = "Rasmus";
            kør4.mand.navn = "Khalid";
            kør5.mand.navn = "Tommy";

            kør1.mand.status = "Tilgængelig";
            kør2.mand.status = "Tilgængelig";
            kør3.mand.status = "Tilgængelig";
            kør4.mand.status = "Tilgængelig";
            kør5.mand.status = "Tilgængelig";

            chaufførlist.Add(kør1.mand);
            chaufførlist.Add(kør2.mand);
            chaufførlist.Add(kør3.mand);
            chaufførlist.Add(kør4.mand);
            chaufførlist.Add(kør5.mand);

            TaxaStatus.ItemsSource = chaufførlist;
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
            if (vis != null)
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
