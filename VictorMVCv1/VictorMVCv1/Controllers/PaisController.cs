using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VictorMVCv1.Controllers
{
    public class PaisController : Controller
    {
        // GET: PaisController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: PaisController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaisController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaisController1/Create
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

        // GET: PaisController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaisController1/Edit/5
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

        // GET: PaisController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaisController1/Delete/5
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
