using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Acuario_Javier_EsmeradoVela
{
   public class AcuarioData
    {
        private String name;
        public string Nombresala
        {
            get { return name; }
            set
            {
                this.name = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Nombre de Sala"));
            }
        }
        private String temperatura;
        public string Temperatura
        {
            get { return temperatura; }
            set
            {
                this.temperatura = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Temperatura"));
            }
        }
        private String especie;
        public string Especie
        {
            get { return especie; }
            set
            {
                this.especie = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Especie"));
            }
        }
        private DateTime fecharevision;
        public DateTime Fecharevision
        {
            get { return fecharevision; }
            set
            {
                this.fecharevision = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Fecha_revision"));
            }
        }
        private String tratamiento;
        public string Tratamiento
        {
            get { return tratamiento; }
            set
            {
                this.tratamiento = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Tratamiento"));
            }
        }
        
        public AcuarioData() { }

        public AcuarioData(string name, string temperatura, string especie, DateTime fecha_revision, string tratamiento)
        {
            this.name = name;
            this.temperatura = temperatura;
            this.especie = especie;
            this.fecharevision = fecha_revision;
            this.tratamiento = tratamiento;
        }

        private void PropertyChanged(AcuarioData AcuarioData, PropertyChangedEventArgs propertyChangedEventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
