﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplicacionDeBiblioteca.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AplicacionDeBiblioteca.UI.Controllers
{
    public class LibrosController : Controller
    {

        private AplicacionDeBiblioteca.UI.Models.IRepositorioDeLibros Repositorio;

        public LibrosController(AplicacionDeBiblioteca.UI.Models.IRepositorioDeLibros repositorioDelConstructor)
        {
            Repositorio = repositorioDelConstructor;
        }

        // GET: Libros
        public ActionResult Index()
        {
            List<Libro> laLista;
            laLista = Repositorio.ObtenerTodos();
            return View(laLista);
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
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

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Libros/Edit/5
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

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libros/Delete/5
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