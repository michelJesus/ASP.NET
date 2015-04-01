using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC_CRUD.Models
{
    public class Veiculo
    {
        public int VeiculoID { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string UrlFoto { get; set; }
        public bool Financiado { get; set; }
    }
}