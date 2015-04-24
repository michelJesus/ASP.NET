using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCEmpty.Models
{
    public class TipoDeDespesa
    {
        public TipoDeDespesa(string descricao)
        {
            this.Descricao = descricao;
        }

        public TipoDeDespesa()
        {
        }
        public int TipoDeDespesaID { get; set; }
        public String Descricao { get; set; }
    }
}