using AspNETMVCdoZero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNETMVCdoZero.Controllers
{
    public class PessoaController : Controller
    {

        public ActionResult Basic()
        {
            return View();
        }

        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        //POST : Pessoa
        [HttpPost]
        public JsonResult Create()
        {
            Pessoa p = new Pessoa();
            p.Nome = Request.Form["Nome"];
            p.Sobrenome = Request.Form["Sobrenome"];

            Banco banco = new Banco();
            banco.Pessoas.Add(p);
            banco.SaveChanges();

            List<Pessoa> lista = banco.Pessoas.ToList();
            return Json(lista);
        }
    }
}