using AspNetMVCEmpty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMVCEmpty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Pessoa p = new Pessoa();
            p.Nome = "João";
            p.Sobrenome = "Silva";

            //List<Pessoa> lista = new List<Pessoa>();

            ViewBag.AlgumDado = "Um texto qualquer!";
            ViewBag.Pessoa = p;
            //ViewBag.Lista = lista;

            return View();
        }

        public ActionResult UmNomeQualquer (string p) 
        {
            //var parametro = Request.QueryString["p"];
            return View();
        }

        [HttpPost]
        public string OutraAction (string nome) 
        {
            
            return "Action OutraAction";
        }
    }
}