using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MfpeDrugsApi.Models;
using MfpeDrugsApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MfpeDrugsApi.Controllers
{
    public class DrugApiController : Controller
    {
        IRepository<Drug> _item;

        public DrugApiController(IRepository<Drug> drugrepo)
        {
            _item = drugrepo;

        }
        /*[HttpGet]
        public IEnumerable<Drug> GetAll(string name)
        {
           return _item.GetAll(name);
            
        }*/

        [HttpGet("{id:int}", Name = "Get")]
        public Drug Get(int id)
        {
            return _item.Get(id);
        }


        [HttpGet("{name}")]
        public Drug Get(string name)
        {
            return _item.Get(name);
        }

        // GET: DrugApiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: DrugApiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DrugApiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrugApiController/Create
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

        // GET: DrugApiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DrugApiController/Edit/5
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

        // GET: DrugApiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DrugApiController/Delete/5
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
