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
    /// Lógica de interacción para Salas.xaml
    /// </summary>
    public partial class Salas : Window
    {
        public Salas()
        {
            InitializeComponent();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            new Home().Show();
            this.Close();
        }

        private void visita_guiada(object sender, RoutedEventArgs e)
        {
            new Mamiferos().Show();
            this.Close();
        }

        private void mamiferos(object sender, RoutedEventArgs e)
        {
            new Mamiferos().Show();
            this.Close();
        }

        private void tropical(object sender, RoutedEventArgs e)
        {
            new Mamiferos().Show();
            this.Close();
        }

        private void crustaceos(object sender, RoutedEventArgs e)
        {
            new Mamiferos().Show();
            this.Close();
        }

        private void invertebrados(object sender, RoutedEventArgs e)
        {
            new Mamiferos().Show();
            this.Close();
        }
    }
}
