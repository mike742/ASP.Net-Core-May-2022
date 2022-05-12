using ASP.Net_Core_May_2022.Data.MockRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.Net_Core_May_2022.Controllers
{
    public class VendorController : Controller
    {
        private VendorMockRepo _vendorRepo = new VendorMockRepo();
        
        // GET: VendorController
        public ActionResult Index()
        {
            var vendors = _vendorRepo.GetAll();
            return View(vendors);
        }


        // GET: VendorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VendorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VendorController/Create
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

        // GET: VendorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VendorController/Edit/5
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

        // GET: VendorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VendorController/Delete/5
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
