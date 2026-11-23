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
    /// Interaction logic for ChaufførLogIn.xaml
    /// </summary>
    public partial class ChaufførLogIn : Window
    {
        private List<Taxa> loginlist;


        public ChaufførLogIn(List<Taxa> loginlist)
        {
            InitializeComponent();
            this.loginlist = loginlist;
        }

        private void tilbage_Click(object sender, RoutedEventArgs e)
        {
            logIn logInSide = new logIn(loginlist);
            logInSide.Show();
            this.Close();
        }

        private void ChaufLogIn_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            while (i < loginlist.Count)
            {
                if (loginlist[i].chauffør.bn == chaufBN.Text && loginlist[i].chauffør.pass == chaufPass.Text)
                {
                    List<Taxa> chaufLoggedIn = new List<Taxa>();
                    chaufLoggedIn.Add(loginlist[i]);
                    ChaufførSide ChaufSide = new ChaufførSide(loginlist, chaufLoggedIn);
                    ChaufSide.Show();
                    this.Close();
                }
                else
                {

                }
                i++;
            }
        }
    }
}
