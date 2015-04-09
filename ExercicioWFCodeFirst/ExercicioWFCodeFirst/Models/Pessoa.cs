using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioWFCodeFirst.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public int Cpf { get; set; }
    }
}