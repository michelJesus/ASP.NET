using ASPNET_MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_MVC_CRUD.Controllers
{
    public class HomeController : Controller
    {

        BancoDeDados db = new BancoDeDados();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.Veiculos.ToList());
        }

        //GET 
        public ActionResult Incluir()
        {
            return View(new Veiculo());
        }

        [HttpPost]
        public ActionResult Incluir(Veiculo veiculo)
        {
            db.Veiculos.Add(veiculo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            return View(db.Veiculos.Find(id));
        }

        [HttpPost]
        public ActionResult Editar(Veiculo veiculo)
        {
            db.Entry(veiculo).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Excluir(int id)
        {
            return View(db.Veiculos.Find(id));
        }

        [HttpPost]
        public ActionResult Excluir(Veiculo veiculo)
        {
            db.Entry(veiculo).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}