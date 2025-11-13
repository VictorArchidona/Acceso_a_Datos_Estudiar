using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        public readonly IAlumnoRepositorio AlumnoRepositorio;
        public readonly IWebHostEnvironment webHostEnvironment;

        public IFormFile Photo { get; set; }
        [BindProperty]
        public Alumno alumno { get; set; }

        public EditModel(IAlumnoRepositorio alumnoRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.AlumnoRepositorio = alumnoRepositorio;
        }
        public void OnGet(int id)
        {
            alumno = AlumnoRepositorio.GetAlumnoPorId(id);
        }

        public IActionResult OnPost(Alumno alumno)
        {
            if (Photo != null)
            {

                if(alumno.Foto != null)
                {

                    string filePath = Path.Combine(webHostEnvironment.WebRootPath, "images", alumno.Foto);
                    System.IO.File.Delete(filePath);
                }
                alumno.Foto = ProccesUploadFile();
            }

            AlumnoRepositorio.Update(alumno);
            return RedirectToPage("Index");
        }
        public string ProccesUploadFile()
        {
            if(Photo != null)
            {

                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                string filePath = Path.Combine(uploadsFolder, Photo.FileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return Photo.FileName;

        }
    }
}
