using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace Taxa_Station
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Taxa> taxalist = new List<Taxa>();
        public MainWindow()
        {
            InitializeComponent();
            SkabListe();
        }
        public void SkabListe()
        {

            int i = 0;
            int arrayPos = 0;
            string[] load = System.IO.File.ReadAllLines(@"gem1.txt");

            while (i < load.Length/5)
            {
                Taxa taxa = new Taxa();
                taxa.chauffør = new Chauffør();

                taxalist.Add(taxa);
                i++;
            }
            i = 0;
            while (i < taxalist.Count)
            {
                taxalist[i].chauffør.navn = load[arrayPos];
                arrayPos++;
                i++;
            }
            i = 0;
            while (i < taxalist.Count)
            {
                taxalist[i].chauffør.status = load[arrayPos];
                arrayPos++;
                i++;
            }
            i = 0;
            while (i < taxalist.Count)
            {
                taxalist[i].chauffør.bn = load[arrayPos];
                arrayPos++;
                i++;
            }
            i = 0;
            while (i < taxalist.Count)
            {
                taxalist[i].chauffør.pass = load[arrayPos];
                arrayPos++;
                i++;
            }
            


            if (taxalist.Count <= 0)
            {
                Taxa Taxa1 = new Taxa();
                Taxa Taxa2 = new Taxa();
                Taxa Taxa3 = new Taxa();
                Taxa Taxa4 = new Taxa();
                Taxa Taxa5 = new Taxa();

                Taxa1.chauffør = new Chauffør();
                Taxa2.chauffør = new Chauffør();
                Taxa3.chauffør = new Chauffør();
                Taxa4.chauffør = new Chauffør();
                Taxa5.chauffør = new Chauffør();

                Taxa1.chauffør.navn = "Povl";
                Taxa2.chauffør.navn = "Miriam";
                Taxa3.chauffør.navn = "Rasmus";
                Taxa4.chauffør.navn = "Khalid";
                Taxa5.chauffør.navn = "Tommy";

                Taxa1.chauffør.status = "Utilgængelig";
                Taxa2.chauffør.status = "Utilgængelig";
                Taxa3.chauffør.status = "Ledig";
                Taxa4.chauffør.status = "Pause";
                Taxa5.chauffør.status = "Fri";

                Taxa1.chauffør.bn = "Povl";
                Taxa2.chauffør.bn = "Miriam";
                Taxa3.chauffør.bn = "Rasmus";
                Taxa4.chauffør.bn = "Khalid";
                Taxa5.chauffør.bn = "Tommy";

                Taxa1.chauffør.pass = "123";
                Taxa2.chauffør.pass = "456";
                Taxa3.chauffør.pass = "67";
                Taxa4.chauffør.pass = "789";
                Taxa5.chauffør.pass = "000";

                taxalist.Add(Taxa1);
                taxalist.Add(Taxa2);
                taxalist.Add(Taxa3);
                taxalist.Add(Taxa4);
                taxalist.Add(Taxa5);
            }


        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            logIn logInSide = new logIn(taxalist);
            logInSide.Show();
            this.Close();
        }

        private void BestilTaxaButton_Click(object sender, RoutedEventArgs e)
        {
            BestilTaxa bestil = new BestilTaxa(taxalist);
            bestil.Show();
            this.Close();
        }
    }
    public class Taxa
    {
        public Chauffør chauffør;
    }
    public class Chauffør
    {
        public string navn;
        public string status;
        //Brugernavn
        public string bn;
        //Adgangskode
        public string pass;
        public override string ToString()
        {
            return navn + " : " + status;
        }
    }
}