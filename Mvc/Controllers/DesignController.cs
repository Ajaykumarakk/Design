using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Repository;
using Mvc.Models;

namespace Mvc.Controllers
{
    public class DesignController : Controller
    {
        DesignRepository obj;

        public DesignController()
        {
            obj = new DesignRepository();
        }
        // GET: DesignController
        public ActionResult About()
        {
            return View();
        }

        // GET: DesignController/Details/5
        public ActionResult Blog()
        {
            return View();
        }

        // GET: DesignController/Create
        public ActionResult Contact(DesignveiwModel res)
        {
            obj.Insertinfo(res);
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        // POST: DesignController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit()
        {
            
            {
                return View();
            }
        }

        // GET: DesignController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DesignController/Edit/5
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

        // GET: DesignController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DesignController/Delete/5
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
