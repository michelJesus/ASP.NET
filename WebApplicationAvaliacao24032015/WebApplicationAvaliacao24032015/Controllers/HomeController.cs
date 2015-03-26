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
        public JsonResult Incluir(FormCollection colletcion)
        {
            string nome = Request.Form["Nome"];
            //string ativo = Request.Form["Ativo"];

            Cliente c = new Cliente();
            //c.IsAtivo = ativo;
            c.Nome = nome;
            
            banco.Clientes.Add(c);
            banco.SaveChanges();

            return Listar();
        }

        [HttpPost]
        public JsonResult Listar () {
            List<Cliente> lista = banco.Clientes.ToList();
            return Json(lista);
        }

        [HttpPost]
        public JsonResult Excluir () {
            var clienteID = Request.Form["id"];
            Cliente cliente = banco.Clientes.Find(int.Parse(clienteID));

            banco.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();

            return Listar();
        }

        [HttpPost]
        public JsonResult Editar () {
            var clienteID = Request.Form["id"];
            Cliente cliente = banco.Clientes.Find(int.Parse(clienteID));

            banco.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
            banco.SaveChanges();

            return Listar();
        }
    }
}