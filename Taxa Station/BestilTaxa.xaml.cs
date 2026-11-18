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
            List<Chauffør> chaufførlist = new List<Chauffør>();

            Chauffør kør1 = new Chauffør();
            Chauffør kør2 = new Chauffør();
            Chauffør kør3 = new Chauffør();
            Chauffør kør4 = new Chauffør();
            Chauffør kør5 = new Chauffør();

            kør1.navn = "Povl";
            kør2.navn = "Miriam";
            kør3.navn = "Rasmus";
            kør4.navn = "Khalid";
            kør5.navn = "Tommy";

            kør1.status = "Tilgængelig";
            kør2.status = "Tilgængelig";
            kør3.status = "Tilgængelig";
            kør4.status = "Tilgængelig";
            kør5.status = "Tilgængelig";

            chaufførlist.Add(kør1);
            chaufførlist.Add(kør2);
            chaufførlist.Add(kør3);
            chaufførlist.Add(kør4);
            chaufførlist.Add(kør5);


            //TaxaStatus.Items.Add(kør1);
            //TaxaStatus.Items.Add(kør2);
            //TaxaStatus.Items.Add(kør3);
            //TaxaStatus.Items.Add(kør4);
            //TaxaStatus.Items.Add(kør5);
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
            Chauffør vis = (Chauffør)TaxaStatus.SelectedItem;
            if (vis != null)
            {
                MessageBox.Show(vis.navn + " : " + vis.status);
            }
        }

        private void valgAfTaxaKnap_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
