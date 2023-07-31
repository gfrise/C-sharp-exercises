using Ex44.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex44.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswerRepo _repo;

        public AnswerController(IAnswerRepo answerRepo)
        {
            _repo = answerRepo;
        }
        // GET: AnswerController
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: AnswerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnswerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerController/Create
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

        // GET: AnswerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnswerController/Edit/5
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

        // GET: AnswerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnswerController/Delete/5
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
