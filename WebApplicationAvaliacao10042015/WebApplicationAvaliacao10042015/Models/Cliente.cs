using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAvaliacao10042015.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Codigo { get; set; }
        public string IsAtivo { get; set; }
        public string Nome { get; set; }
    }
}