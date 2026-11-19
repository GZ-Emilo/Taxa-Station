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
        public List<Chauffør> chaufførlist = new List<Chauffør>();

        public MainWindow()
        {
            InitializeComponent();
            SkabListe();
        }

        public void SkabListe()
        {
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

            kør1.mand.navn = "Povl";
            kør2.mand.navn = "Miriam";
            kør3.mand.navn = "Rasmus";
            kør4.mand.navn = "Khalid";
            kør5.mand.navn = "Tommy";

            kør1.mand.status = "Ledig";
            kør2.mand.status = "Ledig";
            kør3.mand.status = "Ledig";
            kør4.mand.status = "Ledig";
            kør5.mand.status = "Ledig";

            kør1.mand.bn = "";
            kør2.mand.bn = "";
            kør3.mand.bn = "";
            kør4.mand.bn = "";
            kør5.mand.bn = "";

            kør1.mand.pass = "";
            kør2.mand.pass = "";
            kør3.mand.pass = "";
            kør4.mand.pass = "";
            kør5.mand.pass = "";

            chaufførlist.Add(kør1.mand);
            chaufførlist.Add(kør2.mand);
            chaufførlist.Add(kør3.mand);
            chaufførlist.Add(kør4.mand);
            chaufførlist.Add(kør5.mand);


        }
        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            logIn logInSide = new logIn(chaufførlist);
            logInSide.Show();
            this.Close();
        }

        private void BestilTaxaButton_Click(object sender, RoutedEventArgs e)
        {
            BestilTaxa bestil = new BestilTaxa(chaufførlist);
            bestil.Show();
            this.Close();
        }
    }
    public class Taxa
    {
        public Chauffør mand;
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