using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_Produto.Models
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados() : base("MinhaConexao") {}
        public DbSet<Produto> Produtos { get; set; }
    }
}