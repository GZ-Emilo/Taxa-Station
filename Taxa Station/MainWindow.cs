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
        public MainWindow()
        {
            InitializeComponent();
            SkabListe();
        }

        public void SkabListe()
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
            kør3.mand.status = "Tilgænelig";
            kør4.mand.status = "Tilgængelig";
            kør5.mand.status = "Tilgængelig";

            chaufførlist.Add(kør1.mand);
            chaufførlist.Add(kør2.mand);
            chaufførlist.Add(kør3.mand);
            chaufførlist.Add(kør4.mand);
            chaufførlist.Add(kør5.mand);


        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            logIn logInSide = new logIn();
            logInSide.Show();
            this.Close();
        }

        private void BestilTaxaButton_Click(object sender, RoutedEventArgs e)
        {
            BestilTaxa bestil = new BestilTaxa();
            bestil.Show();
            this.Close();
        }
    }
    class Taxa
    {
        public Chauffør mand;
        public int nummer;
    }
    class Chauffør
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