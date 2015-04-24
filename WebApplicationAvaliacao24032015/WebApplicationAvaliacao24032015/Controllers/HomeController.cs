using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationAvaliacao24032015.Models;

namespace WebApplicationAvaliacao24032015.Controllers
{
    public class HomeController : Controller
    {

        BancoDeDados banco = new BancoDeDados();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Incluir()
        {
            string nome = Request.Form["Nome"];
            string ativo = Request.Form["IsAtivo"];

            Cliente c = new Cliente();
            c.Nome = nome;
            c.IsAtivo = ativo;
            
            banco.Clientes.Add(c);
            banco.SaveChanges();

            List<Cliente> lista = banco.Clientes.ToList();
            return Json(lista);
        }
    }
}