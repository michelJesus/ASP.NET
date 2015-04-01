using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_CRUD.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}