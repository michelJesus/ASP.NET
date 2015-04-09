using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNETMVCdoZero.Models
{
    public class Banco : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}