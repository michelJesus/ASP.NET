using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WATarefaJson.Models;

namespace WATarefaJson.Controllers
{
    public class HomeController : Controller
    {

        BancoDeDados db = new BancoDeDados();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create()
        {
            Tarefa t = new Tarefa();
            t.DataConclusao = DateTime.Parse(Request.Form["DataConclusao"]);
            t.DataInicial = DateTime.Parse(Request.Form["DataInicial"]);
            t.Descricao = Request.Form["Descricao"];
            t.Solicitante = Request.Form["Solicitante"];
            t.Status = Request.Form["Status"];

            db.Tarefas.Add(t);
            db.SaveChanges();
            
            return List();
        }

        public JsonResult List()
        {
            List<Tarefa> lista = db.Tarefas.ToList();
            return Json(lista);
        }
    }
}