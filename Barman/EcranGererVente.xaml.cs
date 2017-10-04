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
    /// Logique d'interaction pour EcranGererVente.xaml
    /// </summary>
    public partial class EcranGererVente : UserControl
    {
        public EcranGererVente()
        {
            InitializeComponent();
            tbcOnglet.SelectedItem = tbiVente;
            tbiVente.IsSelected = true;
        }

        private void tbcOnglet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (tbcOnglet.SelectedItem == tbiInventaire)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Clear();
                EcranInventaire EI = new EcranInventaire();
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Add(EI);

            }
            else if (tbcOnglet.SelectedItem == tbiCommande)
            {


                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Clear();
                EcranCommande EC = new EcranCommande();
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Add(EC);

            }
            else if (!tbiVente.IsSelected && tbcOnglet.SelectedItem == tbiVente)
            {
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Clear();
                EcranVente EV = new EcranVente();
                ((MainWindow)System.Windows.Application.Current.MainWindow).GrdPrincipale.Children.Add(EV);
            }
        }
    }
}
