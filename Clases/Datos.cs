using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_of_inheritance.Clases
{
    public class Datos
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Datos()
        {
        }

        public Datos(string nombre, string apellido, string direccion, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int calcEdad()
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if ( fechaNacimiento.Month > fechaActual.Month )
            {
                --edad;
            }
            return edad;
        }
    }
}