using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVCEmpty.Models
{
    public class Banco : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<TipoDeDespesa> TiposDeDespesas { get; set; }
        public DbSet<TipoDeReceita> TiposDeReceitas { get; set; }
    }
}