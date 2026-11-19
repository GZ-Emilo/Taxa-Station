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
        public override string ToString()
        {
            return navn + " : " + status;
        }
    }
}