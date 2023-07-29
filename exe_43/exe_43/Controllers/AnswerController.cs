using exe_43.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace exe_43.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswerRepo _Repo;

        public AnswerController(IAnswerRepo repo)
        {
            this._Repo = repo;    
        }
        // GET: AnswerControlle
        public ActionResult Index()
        {
            return View(_Repo.GetAll());
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

        public ActionResult Show(int id)
        {
            return View(_Repo.GetById(id));
        }
        // POST: AnswerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Answer ans)
        {
            try
            {
                _Repo.Add(ans);

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

            return View(_Repo.GetById(id));
        }

        // POST: AnswerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Answer answer)
        {
            try
            {
                _Repo.Modify(answer);
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
            return View(_Repo.GetById(id));
        }

        // POST: AnswerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                this._Repo.DeleteById(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}