using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace ExercicioWFCodeFirst.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}