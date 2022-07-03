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
        private double horasDiaTrabajadas;
        private double horasNocheTrabajadas;
        private string franja;
        public Trabajador()
        {
        }

        public Trabajador(string identificacion, string nombre, string primerApellido, string segundoApellido, string edad, string tipoCargo, double horasDiaTrabajadas, double horasNocheTrabajadas, string franja) : base(identificacion, nombre, primerApellido, segundoApellido, edad)
        {
            this.tipoCargo = tipoCargo;
            this.horasDiaTrabajadas = horasDiaTrabajadas;
            this.horasNocheTrabajadas = horasNocheTrabajadas;
            this.franja = franja;
        }
    

        public string TipoCargo 
        {
            get { return this.tipoCargo; }
            set { this.tipoCargo = value; } 
        }

        public double HorasDiaTrabajadas
        {
            get { return this.horasDiaTrabajadas; }
            set { this.horasDiaTrabajadas = value; }
        }
        public double HorasNocheTrabajadas
        {
            get { return this.horasNocheTrabajadas; }
            set { this.horasNocheTrabajadas = value; }
        }
        public string Franja
        {
            get { return this.franja; }
            set { this.franja = value; }
        }


}
}
