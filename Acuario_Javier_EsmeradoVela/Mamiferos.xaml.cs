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
    /// Lógica de interacción para Mamiferos.xaml
    /// </summary>
    public partial class Mamiferos : Window
    {
        public Mamiferos()
        {
            InitializeComponent();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            new Tropical().Show();
            this.Close();
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            new Salas().Show();
            this.Close();
        }
    }
}
