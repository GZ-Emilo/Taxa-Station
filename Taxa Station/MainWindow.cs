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

            Taxa1.chauffør.status = "Ledig";
            Taxa2.chauffør.status = "Utilgængelig";
            Taxa3.chauffør.status = "Ledig";
            Taxa4.chauffør.status = "Pause";
            Taxa5.chauffør.status = "Fri";

            Taxa1.chauffør.bn = "";
            Taxa2.chauffør.bn = "";
            Taxa3.chauffør.bn = "";
            Taxa4.chauffør.bn = "";
            Taxa5.chauffør.bn = "";

            Taxa1.chauffør.pass = "";
            Taxa2.chauffør.pass = "";
            Taxa3.chauffør.pass = "";
            Taxa4.chauffør.pass = "";
            Taxa5.chauffør.pass = "";

            taxalist.Add(Taxa1);
            taxalist.Add(Taxa2);
            taxalist.Add(Taxa3);
            taxalist.Add(Taxa4);
            taxalist.Add(Taxa5);


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
        public int nummer;
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