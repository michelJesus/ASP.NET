using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCEmpty.Models;

namespace WebMVCEmpty.Controllers
{
    public class ReceitaController : Controller
    {

        BancoDeDados banco = new BancoDeDados();

        // GET: Receita
        public ActionResult Index()
        {
            return View();
        }

        // GET: Receita/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Receita/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receita/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                string valor = Request.Form["Valor"];

                Receita receita = new Receita();
                receita.Valor = decimal.Parse(valor);
                banco.Receitas.Add(receita);
                banco.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receita/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Receita/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                string receita = Request.Form["Valor"];
                TryUpdateModel(receita);
                banco.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receita/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Receita/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Receita receita = banco.Receitas.Find("Valor");
                banco.Receitas.Remove(receita);
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
