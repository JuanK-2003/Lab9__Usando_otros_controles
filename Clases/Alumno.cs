using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise_of_inheritance.Clases
{
    public class Nota
    {
        public double calificacion { get; set; }

        public string curso { get; set; }
    }

    public class Alumno : Datos
    {
        public string Carne { get; set; }
        List<Nota> notas = new List<Nota>();

        public List<Nota> Notas { get => notas; set => notas = value; }

        public Alumno()
        {
            Notas = new List<Nota>();
        }
    }
}