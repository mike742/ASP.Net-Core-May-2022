using ASP.Net_Core_May_2022.Data.MockRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace ASP.Net_Core_May_2022.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductMockRepo _productRepo = new ProductMockRepo();
        private readonly VendorMockRepo _vendorRepo = new VendorMockRepo();

        // GET: ProductController
        public ActionResult Index()
        {
            return View(_productRepo.GetAll());
        }

        public List<string> GetProductsByVendorId(int? id)
        {
            var res = _productRepo.GetAll()
                .Where(p => p.V_code == id)
                .Select(o => $"{o.P_code}: {o.P_descript} -${o.P_Price}<br> ")
                .ToList();

            if (res == null || res.Count == 0)
            {
                return new List<string>() { "No Product found" };
            }

            return res;
        }


        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            ViewBag.Vendors = 
                new SelectList(_vendorRepo.GetAll(), "V_code", "V_name");
            return View();
        }

        // POST: ProductController/Create
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
