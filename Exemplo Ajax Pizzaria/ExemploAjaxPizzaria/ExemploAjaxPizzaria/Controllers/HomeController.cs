using ExemploAjaxPizzaria.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ExemploAjaxPizzaria.Controllers
{
    public class HomeController : Controller
    {
        BancoDeDados db = new BancoDeDados();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GravarProduto()
        {
            Produto p = null;
            var produtoID = Request.Form["id"];
            if (produtoID.Equals("0"))
            {
                p = new Produto();
                db.Produtos.Add(p);
            }
            else
            {
                p = db.Produtos.Find(int.Parse(produtoID));
                p.Insumos.ToList().ForEach(insumo => p.Insumos.Remove(insumo));
                db.Entry(p).State = System.Data.Entity.EntityState.Modified;
            }

            p.Nome = Request.Form["nome"];

            var insumosIds = Request.Form["insumos"];
            if (insumosIds != "null")
            {
                JavaScriptSerializer jss = new JavaScriptSerializer();
                string[] ids = jss.Deserialize<string[]>(insumosIds);
                foreach (string id in ids)
                {
                    Insumo insumo = db.Insumos.Find(int.Parse(id));
                    p.Insumos.Add(insumo);
                }
            }
            db.SaveChanges();

            return CarregarProdutos();
        }

        [HttpPost]
        public JsonResult ExcluirProduto()
        {
            var produtoID = Request.Form["id"];
            Produto p = db.Produtos.Find(int.Parse(produtoID));
            p.Insumos.ToList().ForEach(insumo => p.Insumos.Remove(insumo));
            db.Entry(p).State = EntityState.Deleted;
            db.SaveChanges();

            return CarregarProdutos();
        }

        public JsonResult CarregarProduto()
        {
            var produtoID = int.Parse(Request.QueryString["id"]);
            var p = (from produto in db.Produtos
                    where produto.ProdutoID == produtoID
                    select new { 
                        ProdutoID = produto.ProdutoID,
                        Nome = produto.Nome,
                        Insumos = from insumo in produto.Insumos
                                  select new
                                  {
                                      InsumoID = insumo.InsumoID,
                                      Descricao = insumo.Descricao
                                  }
                    }).FirstOrDefault();
            var listaInsumos = getInsumosQuery();
            var resultado = new { produto = p, insumos = listaInsumos };
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CarregarProdutos()
        {
            return Json(getProdutosQuery(), JsonRequestBehavior.AllowGet);
        }

        private object getProdutosQuery()
        {
            return from p in db.Produtos.ToList()
                   select new
                   {
                       ProdutoID = p.ProdutoID,
                       Nome = p.Nome,
                       Insumos = from i in p.Insumos
                                 select new
                                 {
                                     InsumoID = i.InsumoID,
                                     Descricao = i.Descricao
                                 }
                   };
        }

        [HttpPost]
        public JsonResult GravarInsumo()
        {
            Insumo insumo = null;
            var insumoID = Request.Form["id"];
            if (insumoID.Equals("0"))
            {
                insumo = new Insumo();
                db.Insumos.Add(insumo);
            }
            else
            {
                insumo = db.Insumos.Find(int.Parse(insumoID));
                db.Entry(insumo).State = System.Data.Entity.EntityState.Modified;
            }

            insumo.Descricao = Request.Form["descricao"];
            db.SaveChanges();

            return CarregarInsumos();
        }

        [HttpPost]
        public JsonResult ExcluirInsumo()
        {
            var insumoID = Request.Form["id"];
            Insumo insumo = db.Insumos.Find(int.Parse(insumoID));
            db.Entry(insumo).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();

            return CarregarInsumos();
        }

        public JsonResult CarregarInsumo()
        {
            var insumoID = int.Parse(Request.QueryString["id"]);
            var insumos = (from insumo in db.Insumos
                          where insumo.InsumoID == insumoID
                          select new
                          {
                              InsumoID = insumo.InsumoID,
                              Descricao = insumo.Descricao
                          }).FirstOrDefault();
            return Json(insumos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult CarregarInsumos()
        {
            return Json(getInsumosQuery(), JsonRequestBehavior.AllowGet);
        }

        private object getInsumosQuery()
        {
            return from i in db.Insumos.ToList()
                   select new
                   {
                       InsumoID = i.InsumoID,
                       Descricao = i.Descricao
                   };
        }
    }
}