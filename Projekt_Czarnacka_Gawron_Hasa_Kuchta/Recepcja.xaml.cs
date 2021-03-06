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
using System.Windows.Shapes;
using System.Data.SqlClient;
namespace Projekt_Czarnacka_Gawron_Hasa_Kuchta
{
    /// <summary>
    /// Logika interakcji dla klasy Recepcja.xaml
    /// </summary>
    public partial class Recepcja : Window
    {
        SqlConnection conn;
        string userName;
        public Recepcja()
        {
            InitializeComponent();
        }
        public Recepcja(SqlConnection conn,string userName)
        {
            InitializeComponent();
            this.conn = conn;
            this.userName = userName;
            //status i zalogowano jako
            statusLbl.Content = conn.State.ToString();
            userLbl.Content = userName;
        }

        private void nowyPacjent_Click(object sender, RoutedEventArgs e)
        {
            PanelDodawaniePacjenta.Visibility = Visibility.Visible;
            PanelDodawanieWizyty.Visibility = Visibility.Collapsed;
            PanelEdycjaWizyty.Visibility = Visibility.Collapsed;
        }

        private void nowaWizyta_Click(object sender, RoutedEventArgs e)
        {
            PanelDodawanieWizyty.Visibility = Visibility.Visible;
            PanelDodawaniePacjenta.Visibility = Visibility.Collapsed;
            PanelEdycjaWizyty.Visibility = Visibility.Collapsed;

        }

        private void edycjaWizyty_Click(object sender, RoutedEventArgs e)
        {
            PanelDodawanieWizyty.Visibility = Visibility.Collapsed;
            PanelDodawaniePacjenta.Visibility = Visibility.Collapsed;
            PanelEdycjaWizyty.Visibility = Visibility.Visible;
        }
    }
}
