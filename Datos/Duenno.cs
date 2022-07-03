using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Duenno : Persona
    {
        private string cargoAdministrativo;
        private int cantidadAcciones;

        public Duenno()
        {

        }

        public Duenno(string identificacion, string nombre, string primerApellido, string segundoApellido, string edad, string cargoAdministrativo, int cantidadAcciones) : base(identificacion, nombre, primerApellido, segundoApellido, edad)
        {
            this.cargoAdministrativo = cargoAdministrativo;
            this.cantidadAcciones = cantidadAcciones;
        } 

        public string CargoAdministrativo
        {
            get { return this.cargoAdministrativo; }
            set { this.cargoAdministrativo = value; }
        }
        public int CantidadAcciones
        {
            get { return this.cantidadAcciones; }
            set { this.cantidadAcciones = value; }
        }

    }
}
