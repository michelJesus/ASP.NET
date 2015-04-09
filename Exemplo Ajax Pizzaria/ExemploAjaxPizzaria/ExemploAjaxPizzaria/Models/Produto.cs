using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploAjaxPizzaria.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }

        public virtual List<Insumo> Insumos { get; set; } 

        public Produto() {
            Insumos = new List<Insumo>();
        }
    }
}