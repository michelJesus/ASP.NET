using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace WebMVCEmpty.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<TipoDeReceita> TiposDeReceitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<TipoDeDespesa> TiposDeDespesas { get; set; }
    }
}