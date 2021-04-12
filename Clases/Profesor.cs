using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_of_inheritance.Clases
{
    public class Profesor : Datos
    {
        public string titulo { get; set; }

        public Profesor()
        {
        }

        public Profesor(string nombre, string apellido, string direccion, DateTime fechaNacimiento, string titulo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.fechaNacimiento = fechaNacimiento;
            this.titulo = titulo;
        }
    }
}