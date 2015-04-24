using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAvaliacao01042015.Models;

namespace WebApplicationAvaliacao01042015.Controllers
{
    public class IndexController : Controller
    {

        BancoDeDados Banco = new BancoDeDados();

        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Incluir()
        {
            string nome = Request.Form["Nome"];
            string isValue = Request.Form["IsValue"];

            Cliente c = new Cliente();
            c.Nome = nome;
            c.IsAtivo = isValue;

            Banco.Clientes.Add(c);
            Banco.SaveChanges();

            List<Cliente> lista = Banco.Clientes.ToList();
            return Json(lista);
        }
    }
}