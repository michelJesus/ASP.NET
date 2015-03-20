using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastroDeProduto.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public virtual List<Insumo> Insumos { get; set; }
    }
}