using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCEmpty.Models;

namespace WebMVCEmpty.Controllers
{
    public class TipoDeDespesaController : Controller
    {

        BancoDeDados banco = new BancoDeDados();

        // GET: TipoDeDespesa
        public ActionResult Index()
        {
            return View();
        }

        // GET: TipoDeDespesa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TipoDeDespesa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoDeDespesa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                // BancoDeDados banco = new BancoDeDados();

                string valor = Request.Form["Descricao"];

                TipoDeDespesa tipo = new TipoDeDespesa();
                tipo.Descricao = valor;
                banco.TiposDeDespesas.Add(tipo);
                banco.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoDeDespesa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoDeDespesa/Edit/5
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

        // GET: TipoDeDespesa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoDeDespesa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                TipoDeDespesa tipo = banco.TiposDeDespesas.Find("Descricao");
                banco.TiposDeDespesas.Remove(tipo);
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
