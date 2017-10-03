using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Barman
{
    /// <summary>
    /// Interaction logic for EcranAjoutInventaire.xaml
    /// </summary>
    public partial class EcranAjoutInventaire : UserControl
    {
        public EcranAjoutInventaire()
        {
            InitializeComponent();
            tbcOnglet.SelectedItem = tbiInventaire;
            tbiInventaire.IsSelected = true;
        }


        private void tbcOnglet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            if (!tbiInventaire.IsSelected && tbcOnglet.SelectedItem == tbiInventaire)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Clear();
                EcranInventaire EI = new EcranInventaire();
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Add(EI);

            }
            if (tbcOnglet.SelectedItem == tbiCommande)
            {


                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Clear();
                EcranCommande EC = new EcranCommande();
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Add(EC);
            }

        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAugmenteQ_Click(object sender, RoutedEventArgs e)
        {
            int quantite;
            try
            {
                quantite = Int32.Parse(txtQuantite.Text);
                quantite++;
                txtQuantite.Text = quantite.ToString();
            }
            catch(Exception ex)
            {
                quantite = 1;
                txtQuantite.Text = quantite.ToString();
            }
        }

        private void btnReduireQ_Click(object sender, RoutedEventArgs e)
        {
            int quantite;
            try
            {
                quantite = Int32.Parse(txtQuantite.Text);
                if (quantite > 1)
                    quantite--;
                txtQuantite.Text = quantite.ToString();
            }
            catch(Exception ex)
            {
                quantite = 1;
                txtQuantite.Text = quantite.ToString();
            }
        }
    }
}
