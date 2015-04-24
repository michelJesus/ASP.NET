using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Avaliacao_2_14042015.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}