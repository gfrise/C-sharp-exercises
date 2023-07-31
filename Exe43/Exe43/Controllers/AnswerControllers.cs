using Exe43.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exe43.Controllers
{
    public class AnswerControllers : Controller
    {
        private readonly IAnswerRepo _repo;

        public AnswerControllers(IAnswerRepo answerRepo)
        {
            _repo = answerRepo;
        }
        // GET: AnswerControllers
        public ActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: AnswerControllers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnswerControllers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerControllers/Create
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

        // GET: AnswerControllers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnswerControllers/Edit/5
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

        // GET: AnswerControllers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnswerControllers/Delete/5
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
