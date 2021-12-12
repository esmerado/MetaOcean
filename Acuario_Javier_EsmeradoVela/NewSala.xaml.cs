using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Lógica de interacción para NewSala.xaml
    /// </summary>
    public partial class NewSala : Window
    {
        AcuarioData acuarioData;
        private int index;
        public NewSala()
        {
            InitializeComponent();
            this.index = -1;
            acuarioData = new AcuarioData();
            this.DataContext = acuarioData;
        }
        public NewSala(int index)
        {
            InitializeComponent();
            this.index = index;
            acuarioData = new AcuarioData();
            this.DataContext = ControlPiscinas.logic.ListaSalas.ElementAt(index);
        }

        private void Form_add(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(input_name.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos, NAME.", "Empty Name");
            }
            else if (String.IsNullOrEmpty(input_temperatura.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos, TEMPERATURA.", "Empty Temperatura");
            }
            else if (String.IsNullOrEmpty(input_especie.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos, ESPECIE.", "Empty ESPECIE");
            }
            else if (String.IsNullOrEmpty(input_fecharevision.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos, FECHA REVISION.", "Empty Fecha revision");
            }
            else if (String.IsNullOrEmpty(input_tratamiento.Text))
            {
                MessageBox.Show("Debes rellenar todos los campos, TRATAMIENTO.", "Empty Tratamiento");
            }
            else
            {
                if (index > -1)
                {
                    acuarioData = new AcuarioData(input_name.Text, input_temperatura.Text, input_especie.Text, input_fecharevision.DisplayDate, input_tratamiento.Text);
                    ControlPiscinas.logic.ModificarSala(index, acuarioData);
                    this.Close();
                }
                else
                {
                    acuarioData = new AcuarioData(input_name.Text, input_temperatura.Text, input_especie.Text, input_fecharevision.DisplayDate, input_tratamiento.Text);
                    ControlPiscinas.logic.AgregarSala(acuarioData);
                    this.Close();
                }
                acuarioData = new AcuarioData();
                this.DataContext = acuarioData;
            }
        }
        private void Form_cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
