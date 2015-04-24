using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WATarefaJson.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}