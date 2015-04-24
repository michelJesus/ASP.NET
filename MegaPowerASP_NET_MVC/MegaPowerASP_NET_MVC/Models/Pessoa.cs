using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaPowerASP_NET_MVC.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        [Display(Name="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public bool IsCasada { get; set; }
        public Sexo Sexo { get; set; }
    }

    public enum Sexo
    {
        Masculino,
        Feminino
    }
}