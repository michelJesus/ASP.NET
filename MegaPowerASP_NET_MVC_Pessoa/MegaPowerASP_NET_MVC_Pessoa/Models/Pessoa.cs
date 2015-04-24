using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaPowerASP_NET_MVC_Pessoa.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Codigo { get; set; }
        public bool IsAtivo { get; set; }
        public string Nome { get; set; }
    }
}