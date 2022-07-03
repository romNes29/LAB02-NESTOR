using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class Persona
    {
        private string identificacion;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string edad;

        public Persona()
        {
        }
        public Persona(string identificacion, string nombre, string primerApellido, string segundoApellido, string edad)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.edad = edad;
        }

        public string Identificacion { 
            get { return this.identificacion; }
            set { this.identificacion = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string PrimerApellido
        {
            get { return this.primerApellido; }
            set { this.primerApellido = value; }
        }
        public string SegundoApellido
        {
            get { return this.segundoApellido; }
            set { this.segundoApellido = value; }
        }
        public string Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


    }
}
