using CadastroDeProduto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroDeProduto.Controllers
{
    public class HomeController : Controller
    {

        BancoDeDados banco = new BancoDeDados();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create (FormCollection colletcion)
        {
            string nome = Request.Form["Nome"];

            Produto p = new Produto();
            p.Nome = nome;

            banco.Produtos.Add(p);
            banco.SaveChanges();

            List<Produto> lista = banco.Produtos.ToList();

            return Lista();
        }

        [HttpPost]
        public JsonResult Excluir ()
        {
            var produtoID = Request.Form["id"];
            Produto produto = banco.Produtos.Find(int.Parse(produtoID));
            banco.Entry(produto).State = System.Data.Entity.EntityState.Deleted;
            banco.SaveChanges();

            return Lista();
            
        }

        public JsonResult Lista () {
            List<Produto> lista = banco.Produtos.ToList();
            return Json(lista);
        }
    }
}