using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCEmpty.Models
{
    public class Despesa
    {
        public int DespesaID { get; set; }
        public DateTime Data { get; set; }
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
        public TipoDeDespesa Tipo { get; set; }
        public Conta Conta { get; set; }
    }
}