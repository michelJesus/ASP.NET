using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExercicioWFCodeFirst.Models;
using System.Web.ModelBinding;

namespace ExercicioWFCodeFirst
{
    public partial class Detalhes : System.Web.UI.Page
    {

        BancoDeDados db = new BancoDeDados();

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Pessoa pessoa_GetItem([QueryString]int PessoaID)
        {
            return db.Pessoas.Find(PessoaID);
        }

        protected void voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}