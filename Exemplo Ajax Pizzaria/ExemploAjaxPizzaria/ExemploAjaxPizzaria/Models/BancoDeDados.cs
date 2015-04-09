using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExemploAjaxPizzaria.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
    }
}