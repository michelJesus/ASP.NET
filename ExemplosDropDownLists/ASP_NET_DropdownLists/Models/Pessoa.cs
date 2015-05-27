using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_NET_DropdownLists.Controllers;

namespace ASP_NET_DropdownLists.Models
{
    public class Pessoa
    {
        public string Sexo { get; set; }
        public string Estatura { get; set; }
        public string EstadoCivil { get; set; }
        public string Cabelos { get; set; }
        public Habito Habito { get; set; }
    }
}