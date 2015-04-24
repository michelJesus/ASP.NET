using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVCEmpty.Models;

namespace WebApplicationMVCEmpty.Controllers
{
    public class PessoaController : Controller
    {

        BancoDeDados banco = new BancoDeDados();

        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        // POST : Pessoa
        [HttpPost]
        public JsonResult Create (FormCollection collection){
            string nome = Request.Form["Nome"];
            string sobrenome = Request.Form["Sobrenome"];
            
            Pessoa p = new Pessoa();
            p.Nome = nome;
            p.Sobrenome = sobrenome;

            banco.Pessoas.Add(p);
            banco.SaveChanges();

            List<Pessoa> lista = banco.Pessoas.ToList();

            return Json(lista);
        }
    }
}