using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ExemploAjaxPizzaria.Models
{
    public class Insumo
    {
        public int InsumoID { get; set; }
        public string Descricao { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}