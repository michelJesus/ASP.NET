using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_DropdownLists.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Habito> listaDeHabitos = new List<Habito>();
            listaDeHabitos.Add(new Habito() { Id = 1, Descricao = "Caminhar" });
            listaDeHabitos.Add(new Habito() { Id = 2, Descricao = "Ler" });
            listaDeHabitos.Add(new Habito() { Id = 3, Descricao = "Estudar" });

            Contexto ctx = new Contexto();
            ViewBag.Habitos = Conversor.ToSelectList(listaDeHabitos, 1);

            ViewBag.OutrosHabitos = Conversor.ToSelectListItems(listaDeHabitos, 1);

            //var stringsNaController = new[] { "Baixa", "Média", "Alta"};
            var stringsNaController = new List<string> { "Baixa", "Média", "Alta" };

            var stringsValoresNaController = new[]{
              new SelectListItem{ Value = "1", Text = "Solteiro"},
              new SelectListItem{ Value = "2", Text = "Casado"}
            };

            ViewBag.StringsValoresNaController = new SelectList(
                stringsValoresNaController, "Value", "Text");

            ViewBag.StringsNaController = new SelectList(stringsNaController);
            return View();
        }
    }
}
