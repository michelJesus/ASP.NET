using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationMVCEmpty.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}