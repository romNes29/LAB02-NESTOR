using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class Procesos
    {
        private List<Trabajador> listaTrabajadores;
        private List<Duenno> listaDuennos;
        private double precioHoraDia;
        private double precioHoraNoche;

        public Procesos()
        {
            listaTrabajadores = new List<Trabajador>();
            listaDuennos = new List<Duenno>();
            precioHoraDia = 15;
            precioHoraNoche = 25;
        }

        public void registrarTrabajador(string identificacion, string nombre, string apellidoUno, string apellidoDos,
            string edad, string tipoCargo, double horasDiaTrabajadas, double horasNocheTrabajadas, string franja)
        {
            listaTrabajadores.Add(new Trabajador(identificacion,nombre, apellidoUno,apellidoDos,edad,tipoCargo,horasDiaTrabajadas, horasNocheTrabajadas, franja));
        }
        public void registraDuennos(string identificacion, string nombre, string primerApellido, string segundoApellido, string edad, string cargoAdministrativo, int cantidadAcciones)
        {
            listaDuennos.Add(new Duenno(identificacion, nombre, primerApellido, segundoApellido, edad, cargoAdministrativo, cantidadAcciones));
        }



        public List<Trabajador> ListaTrabajadores
        {
            get { return this.listaTrabajadores; }
            set { this.listaTrabajadores = value; }

        }
        public List<Duenno> ListaDuennos
        {
            get { return this.listaDuennos; }
            set { this.listaDuennos = value; }

        }
    }
}
