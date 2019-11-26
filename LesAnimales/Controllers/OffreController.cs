using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LesAnimales.Models;

namespace LesAnimales.Controllers
{
    public class OffreController : Controller
    {
        // GET: Offre
        public ActionResult Index()
        {
            var galerie = new List<Offre>()
            {
                new Offre(id:1, titre:"Lilian le Kraken", description:"Lilian est en gentil kraken affectif", photo:"kraken.png", prix:10.00),
                new Offre(id:2, titre:"Matthieu le Raton", description:"Matthieu est un adorable raton calin", photo:"raton.png", prix:12.00),
                new Offre(id:3, titre:"Benjamin L'écureuil", description:"Benjamin est un écureuil curieux", photo:"ecu.png", prix:100.00)
            };
            return View(galerie);
        }

        // GET: Offre/Details/5
        public ActionResult Details(int id)
        {
            return View();
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