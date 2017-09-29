﻿using System;
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
   /// Logique d'interaction pour MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window
   {
        private EcranInventaire Ecraninventaire { get; set; }
      public MainWindow()
      {
         InitializeComponent();
      }

        private void btnInventaire_Click(object sender, RoutedEventArgs e)
        {
            GrdPrincipale.Children.Clear();
            Ecraninventaire = new EcranInventaire();
            GrdPrincipale.Children.Add(Ecraninventaire);

        }

        private void btnEmploye_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCommande_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFormulaireBouteille_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
