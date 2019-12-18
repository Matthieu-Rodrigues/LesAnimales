using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LesAnimales.Models;
using Microsoft.AspNetCore.Http;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using LesAnimales.Models;
using Dapper;

namespace LesAnimales.Controllers
{
    public class OffreController : Controller
    {
        private IOffreRepository OffreRepository;

        public OffreController(IOffreRepository offreRepository)
        {
            this.OffreRepository = offreRepository;
        }

        // GET: Offre
        public ActionResult Index()
        {
            return View(OffreRepository.AllOffres);
        }

        // GET: Offre/Details/5
        public ActionResult Details(int id)
        {
            return View(OffreRepository.GetById(id));
        }

        // GET: Offre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Offre/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Offre/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }

        // POST: Offre/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Offre/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Offre/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
