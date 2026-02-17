using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VictorMVCv1.Models;

namespace VictorMVCv1.Controllers
{
    public class AutorController : Controller
    {
        public Contexto Contexto { get; set; }

        public AutorController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: AutorController1
        public ActionResult Index()
        {
            List<autores> autores = Contexto.autores.Include(a => a.nom_autor).ToList();

            return View();
        }

        // GET: AutorController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AutorController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutorController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutorController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AutorController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AutorController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AutorController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
