using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCEmpty.Models
{
    public class Conta
    {
        public int ContaID { get; set; }
        public DateTime DataDeAbertura { get; set; }
        public String Identificacao { get; set; }
        public Decimal Saldo { get; set; }
        public virtual List<Despesa> Despesas { get; set; }
        public virtual List<Receita> Receitas { get; set; }
    }
}