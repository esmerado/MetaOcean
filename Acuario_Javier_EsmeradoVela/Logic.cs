using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acuario_Javier_EsmeradoVela
{
    public class Logic
    {
        public ObservableCollection<AcuarioData> ListaSalas { get; set; }

        public Logic()
        {
            ListaSalas = new ObservableCollection<AcuarioData>();
        }

        public void AgregarSala(AcuarioData salas)
        {
            ListaSalas.Add(salas);
        }

        public void EliminarSala(int index)
        {
            ListaSalas.RemoveAt(index);
        }

        public void ModificarSala(int index, AcuarioData salas)
        {
            ListaSalas[index] = salas;
        }

        
    }
}
