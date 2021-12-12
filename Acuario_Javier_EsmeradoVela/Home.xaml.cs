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

namespace Acuario_Javier_EsmeradoVela
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ControlPiscinas(object sender, RoutedEventArgs e)
        {
            new ControlPiscinas().Show();
            this.Close();
        }

        private void Salas(object sender, RoutedEventArgs e)
        {
            new Salas().Show();
            this.Close();
        }

        private void Minijuegos(object sender, RoutedEventArgs e)
        {
            new Minijuegos().Show();
            this.Close();
        }

        private void Contacto(object sender, RoutedEventArgs e)
        {
            new Contacto().Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
