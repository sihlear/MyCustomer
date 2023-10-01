using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IPS.Controllers
{
    public class CustomerController : ControllerBase
    {
        // GET: CustomerController
        public ActionResult Index()
        {
            return null;//View();
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return null;//View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return null;//View();
        }

        // POST: CustomerController/Create
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
                return null;// View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return null;// View();
        }

        // POST: CustomerController/Edit/5
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
                return null;// View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return null;// View();
        }

        // POST: CustomerController/Delete/5
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
                return null;// View();
            }
        }
    }
}
