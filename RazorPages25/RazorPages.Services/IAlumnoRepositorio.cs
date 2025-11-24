using RazorPages.Modelos;

namespace RazorPages.Services
{
    public interface IAlumnoRepositorio
    {
        IEnumerable<Alumno> GetAllAlumnos();
        Alumno GetAlumno(int id);
        void Update(Alumno alumnoActualizado);
        void Add(Alumno alumnoNuevo);
        void Delete(int id);
        public IEnumerable<CursoCuantos> AlumnosPorCurso(Curso? curso);
        public IEnumerable<Alumno> Busqueda(string elementoABuscar);
        public IEnumerable<Alumno> GetAlumnosCurso(Curso curso);
    }
}
