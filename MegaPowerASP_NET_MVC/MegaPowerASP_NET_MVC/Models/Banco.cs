using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MegaPowerASP_NET_MVC.Models
{
    public class Banco : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}