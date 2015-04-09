using ExercicioWFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExercicioWFCodeFirst
{
    public partial class Incluir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


        public void pessoa_InsertItem()
        {
            Pessoa pessoa = new Pessoa();
            TryUpdateModel(pessoa);

            if (ModelState.IsValid)
            {

                BancoDeDados db = new BancoDeDados();
                db.Pessoas.Add(pessoa);
                db.SaveChanges();

            }
        }


        protected void pessoa_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Default.aspx");

        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

    }
}