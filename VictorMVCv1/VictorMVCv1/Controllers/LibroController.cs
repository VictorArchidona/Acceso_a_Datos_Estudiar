using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VictorMVCv1.Models;

namespace VictorMVCv1.Controllers
{
    public class LibroController : Controller
    {
        public Contexto Contexto { get; set; } 

        public LibroController(Contexto contexto)
        {
            Contexto = contexto;
        }

        // GET: libro
        public ActionResult Index()
        {
            var lista = Contexto.libros
                .Include(l => l.libroAutores)
                .ThenInclude(la => la.autor)
                .ToList();
            return View(lista);
        }

        // GET: libro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: libro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: libro/Create
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

        // GET: libro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: libro/Edit/5
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

        // GET: libro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: libro/Delete/5
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
