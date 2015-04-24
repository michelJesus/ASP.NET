using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WATarefaJson.Models
{
    public class Tarefa
    {
        public int TarefaID { get; set; }
        public DateTime DataConclusao { get; set; }
        public DateTime DataInicial { get; set; }
        public string Descricao { get; set; }
        public string Solicitante { get; set; }
        public string Status { get; set; }
    }
}