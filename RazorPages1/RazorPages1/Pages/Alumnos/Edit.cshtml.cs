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

        [BindProperty]
        public IFormFile Photo { get; set; }
        [BindProperty]
        public Alumno alumno { get; set; }

        public EditModel(IAlumnoRepositorio alumnoRepositorio, IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.AlumnoRepositorio = alumnoRepositorio;
        }
        public IActionResult OnGet(int? id)
        {
            //Si el id tiene valor, se edita el alumno existente
            if (id.HasValue)
            {
                alumno = AlumnoRepositorio.GetAlumnoPorId(id.Value);
            }
            else
            {
                //Si el id no tiene valor, se crea un nuevo alumno
                alumno = new Alumno();
            }
            return Page();
        }

        public IActionResult OnPost()
        {


            ModelState.Remove("Photo");
            //Si los cambios son correctos
            if (ModelState.IsValid)
            {


                if (Photo != null) //El usuario ha subido una foto nueva?
                {
                    //borra la foto antigua (si existe)
                    if (alumno.Foto != null)
                    {

                        string filePath = Path.Combine(webHostEnvironment.WebRootPath, "images", alumno.Foto);
                        System.IO.File.Delete(filePath);
                    }
                    //sube la nueva foto y actualiza el nombre de la foto en el objeto alumno
                    alumno.Foto = ProccesUploadFile();
                }

                if (alumno.Id > 0)
                {

                    //Es una edicion porque tiene un Id
                    AlumnoRepositorio.Update(alumno);
                }
                else
                {
                    //Es un alta porque no tiene Id
                    AlumnoRepositorio.Add(alumno);
                }

                return RedirectToPage("Index");
            }
            //Si los cmabios no son correctos te redirige a la misma pagina con errores
            return Page();
        }
        public string ProccesUploadFile()
        {
            if(Photo != null) //Existe una foto para procesar?
            {
                //Construir la ruta de carpetas "images" dentro de wwwroot
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");

                //Construye la ruta completa del archivo
                string filePath = Path.Combine(uploadsFolder, Photo.FileName);

                //Crea una tuberia para escribir el archivo en el disco
                using (var fileStream = new FileStream(filePath, FileMode.Create))

                {
                    //Copia el contenido del archivo del formulario al archivo fisico
                    Photo.CopyTo(fileStream);
                }
                //el using de arriba cierra el stream cuando termina
            }
            //Devuelve el nombre del archivo para guardarlo en la BD
            return Photo.FileName; //Ej: "Mifoto.jpg"

        }
    }
}
