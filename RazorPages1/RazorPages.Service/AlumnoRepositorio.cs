using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace RazorPages.Service
{
    public class AlumnoRepositorio : IAlumnoRepositorio
    {
        public List<Alumno> listaAlumnos;

        public Alumno alumno { get; set; }

        public AlumnoRepositorio()
        {
            listaAlumnos = new List<Alumno>()
            {
                new Alumno(){ Id=1, Nombre="Diego Blas", CursoID=Curso.H2, Email="diego@gmail.com", Foto="diego.jpg"},
                new Alumno(){ Id=2, Nombre="Javier Burillo", CursoID=Curso.H2, Email="javier@gmail.com", Foto="javier.png"},
                new Alumno(){ Id=3, Nombre="Jon Fernandez", CursoID=Curso.H1, Email="jon@gmail.com", Foto="jon.png"},
                new Alumno(){ Id=4, Nombre="David Fron", CursoID=Curso.H1, Email="david@gmail.com", Foto="david.png"}
            };
        }

        public Alumno Add(Alumno alumnoNuevo)
        {
            //Asigna el siguiente Id disponible de la lista al alumno nuevo
            alumnoNuevo.Id = listaAlumnos.Max(a => a.Id) + 1;

            //Añade el alumno nuevo a la lista de alumnos
            listaAlumnos.Add(alumnoNuevo);

            //Devuelve el alumno nuevo
            return alumnoNuevo;
        }

        //Se obtienen todos los alumnos
        public IEnumerable<Alumno> GetAllAlumnos()
        {
            return listaAlumnos;
        }

        //Se obtiene el alumno que se haya introducido segun el id
        public Alumno GetAlumnoPorId(int id)
        {
            return listaAlumnos.FirstOrDefault(a => a.Id == id);
        }

        //se actualiza alumno por el alumnoActualizado que se pasa por parametro
        public Alumno Update(Alumno alumnoActualizado)
        {
            //Identifica el alumno en la lista por su Id
            Alumno alumno = listaAlumnos.FirstOrDefault(a => a.Id == alumnoActualizado.Id);

            //Si el alumno existe, se actualizan sus propiedades
            if (alumno != null)
            {
                alumno.Nombre = alumnoActualizado.Nombre;
                alumno.Email = alumnoActualizado.Email;
                alumno.CursoID = alumnoActualizado.CursoID;
                alumno.Foto = alumnoActualizado.Foto;
            }
            return alumno;

        }

        public Alumno Delete(int id)
        {
            //Busco el alumno en la lista de Alumnos por su Id
            Alumno alumnoBorrar = listaAlumnos.FirstOrDefault(a => a.Id == id);

            //Si el alumno existe, se elimina de la lista
            if (alumnoBorrar != null)
            {
                listaAlumnos.Remove(alumnoBorrar);
            }
            return alumnoBorrar;
        }
    }
}
