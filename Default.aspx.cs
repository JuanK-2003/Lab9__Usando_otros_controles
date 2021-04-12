using Exercise_of_inheritance.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise_of_inheritance
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnos = new List<Alumno>();
        static List<Nota> notas = new List<Nota>();
        static List<Profesor> profesor = new List<Profesor>();
        Datos datos = new Datos();

        string AlumnosFiles = "";
        string ProfesorFiles = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if( RadioButton1.Checked)
            {
                TextCarnet.Enabled = false;
                DropDownList1.Enabled = false;
                TextNota.Enabled = false;
                ButtonNota.Enabled = false;
                ButtonAlumno.Enabled = false;
            }

            if ( RadioButton2.Checked)
            {
                TextTitulo.Enabled = false;
                ButtonDocente.Enabled = false;
            }

            AlumnosFiles = Server.MapPath("Alumnos.json");
            ProfesorFiles = Server.MapPath("Profesores.json");
            
            if( validarArchivos() )
            {
                using( StreamReader rd = new StreamReader(AlumnosFiles) )
                {
                    alumnos = JsonConvert.DeserializeObject<List<Alumno>>(rd.ReadToEnd());
                }
                using( StreamReader rd = new StreamReader(ProfesorFiles) )
                {
                    profesor = JsonConvert.DeserializeObject<List<Profesor>>(rd.ReadToEnd());
                }
                
                if( alumnos == null )
                {
                    alumnos = new List<Alumno>();
                }

                if( profesor == null )
                {
                    profesor = new List<Profesor>();
                }
            }

            else
            {
                File.Create(AlumnosFiles);
                File.Create(ProfesorFiles);
            }

            Label5.Text = datos.calcEdad().ToString();
        }

        protected bool validarArchivos()
        {
            return File.Exists(AlumnosFiles)
                &&
                File.Exists(ProfesorFiles);
        }


        protected void RadioButton1_CheckedChanged1(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                TextTitulo.Enabled = true;
                ButtonDocente.Enabled = true;
            }
        }

        protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == true)
            {
                TextCarnet.Enabled = true;
                DropDownList1.Enabled = true;
                TextNota.Enabled = true;
                ButtonAlumno.Enabled = true;
            }
        }

        protected void guardarTodo()
        {
            using (StreamWriter sr = new StreamWriter(AlumnosFiles))
            {
                sr.Write(JsonConvert.SerializeObject(alumnos));
            }
            using (StreamWriter sr = new StreamWriter(ProfesorFiles))
            {
                sr.Write(JsonConvert.SerializeObject(profesor));
            }
        }

        protected void ButtonAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.nombre = TextName.Text;
            alumno.apellido = TextLastName.Text;
            alumno.direccion = TextAddress.Text;
            alumno.fechaNacimiento = Calendar1.SelectedDate;
            alumno.Carne = TextCarnet.Text;
            alumno.Notas = notas.ToList();
            // Agregar data y guardarla
            alumnos.Add(alumno);
            guardarTodo();
            notas.Clear();
            // Seteamos los TextBox en blanco
            TextName.Text = "";
            TextLastName.Text = "";
            TextAddress.Text = "";
            Calendar1.SelectedDate = DateTime.Now;
            TextCarnet.Text = "";
            TextNota.Text = "";
        }

        protected void ButtonDocente_Click(object sender, EventArgs e)
        {
            Profesor profesores = new Profesor();
            profesores.nombre = TextName.Text;
            profesores.apellido = TextLastName.Text;
            profesores.direccion = TextAddress.Text;
            profesores.fechaNacimiento = Calendar1.SelectedDate;
            profesores.titulo = TextTitulo.Text;
            // Agregar data y guardarla
            profesor.Add(profesores);
            guardarTodo();
            // Seteamos los TextBox en blanco
            TextName.Text = "";
            TextLastName.Text = "";
            TextAddress.Text = "";
            Calendar1.SelectedDate = DateTime.Now;
            TextTitulo.Text = "";
        }

        protected void ButtonNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();

            nota.curso = DropDownList1.SelectedValue;
            nota.calificacion = int.Parse(TextNota.Text);
            TextNota.Text = "";
            notas.Add(nota);
        }
    }
}