using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Produto.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public String Descricao { get; set; }
        public Double Preco { get; set; }
    }
}