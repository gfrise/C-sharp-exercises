using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex42_defi.Controllers
{
    public class QuestionController : Controller
    {
        // GET: QuestionController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: QuestionController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuestionController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuestionController1/Create
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

        // GET: QuestionController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuestionController1/Edit/5
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

        // GET: QuestionController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuestionController1/Delete/5
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
