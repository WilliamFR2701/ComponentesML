using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComponentesML.Controllers
{
    public class MLController : Controller
    {
        // GET: ML
        public ActionResult ML()
        {
            return View();
        }

        // GET: ML/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ML/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ML/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ML/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ML/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ML/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ML/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
