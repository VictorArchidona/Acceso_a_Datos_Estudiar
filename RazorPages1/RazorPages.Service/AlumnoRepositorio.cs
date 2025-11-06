using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Service
{
    public class AlumnoRepositorio : IAlumnoRepositorio
    {
        public List<Alumno> listaAlumnos;

        public AlumnoRepositorio()
        {
            listaAlumnos = new List<Alumno>()
            {
                new Alumno(){ Id=1, Nombre="Diego Blas", CursoID=Curso.H2, Email="diego@gmail.com", Foto="diego.webp"},
                new Alumno(){ Id=2, Nombre="Javier Burillo", CursoID=Curso.H2, Email="javier@gmail.com", Foto="javier.png"},
                new Alumno(){ Id=3, Nombre="Jon Fernandez", CursoID=Curso.H1, Email="jon@gmail.com", Foto="jon.webp"},
                new Alumno(){ Id=4, Nombre="David Fron", CursoID=Curso.H1, Email="david@gmail.com", Foto="david.png"}
            };
        }

        public IEnumerable<Alumno> GetAllAlumnos()
        {
            return listaAlumnos;
        }
    }
}
