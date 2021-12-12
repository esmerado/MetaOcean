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
    /// Lógica de interacción para ControlPiscinas.xaml
    /// </summary>
    public partial class ControlPiscinas : Window
    {

        public static Logic logic = new Logic();

        public ControlPiscinas()
        {
            InitializeComponent();
            data.DataContext = logic;
        }

        private void ModificarSala(object sender, RoutedEventArgs e)
        {
            try
            {
                if (data.SelectedIndex != -1)
                {
                    new NewSala(data.SelectedIndex).Show();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Elige una celda con datos", "Excepcion Celda");
            }

        }
        private void AgregarSala(object sender, RoutedEventArgs e)
        {
            new NewSala().Show();

        }

        private void EliminarSala(object sender, RoutedEventArgs e)
        {
            try
            {
                logic.EliminarSala(data.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Elige una celda", "Excepcion Celda");

            }

        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            new Home().Show();
            this.Close();
        }

    }
}
