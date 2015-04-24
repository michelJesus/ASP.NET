using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCEmpty.Models;

namespace WebMVCEmpty.Controllers
{
    public class TipoDeReceitaController : Controller
    {

        BancoDeDados banco = new BancoDeDados();

        // GET: TipoDeReceita
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoDeReceita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoDeReceita/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeReceita/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //BancoDeDados banco = new BancoDeDados();

                string valor = Request.Form["Descricao"];

                TipoDeReceita tipo = new TipoDeReceita();
                tipo.Descricao = valor;
                banco.TiposDeReceitas.Add(tipo);
                banco.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDeReceita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoDeReceita/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                string tipo = Request.Form["Descricao"];
                TryUpdateModel(tipo);
                banco.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDeReceita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoDeReceita/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                TipoDeReceita tipo = banco.TiposDeReceitas.Find("Descricao");
                banco.TiposDeReceitas.Remove(tipo);
                banco.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
