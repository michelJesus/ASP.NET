using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAvaliacao24032015.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public bool IsAtivo { get; set; }
        public string Nome { get; set; }

        public virtual List<Cliente> clientes { get; set; }
    }
}