using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Trabajador : Persona
    {
        private string tipoCargo;
        private double horasTrabajadas;
        private string franja;
        public Trabajador()
        {
        }

        public Trabajador(string identificacion, string nombre, string primerApellido, string segundoApellido, string edad, string tipoCargo, double horasTrabajadas, string franja) : base(identificacion, nombre, primerApellido, segundoApellido, edad)
        {
            this.tipoCargo = tipoCargo;
            this.horasTrabajadas = horasTrabajadas;
            this.franja = franja;
        }
    

        public string TipoCargo 
        {
            get { return this.tipoCargo; }
            set { this.tipoCargo = value; } 
        }

        public double HorasTrabajadas
        {
            get { return this.horasTrabajadas; }
            set { this.horasTrabajadas = value; }
        }

        public string Franja
        {
            get { return this.franja; }
            set { this.franja = value; }
        }


}
}
