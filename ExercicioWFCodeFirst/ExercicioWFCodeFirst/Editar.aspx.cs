using ExercicioWFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExercicioWFCodeFirst.Models;

namespace ExercicioWFCodeFirst
{
    public partial class Editar : System.Web.UI.Page
    {

        BancoDeDados db = new BancoDeDados();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public Pessoa PessoaID_GetItem([QueryString]int PessoaID)
        {
            return db.Pessoas.Find(PessoaID);
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void PessoaID_UpdateItem(int PessoaID)
        {
            Pessoa pessoa = db.Pessoas.Find(PessoaID);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (pessoa == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", PessoaID));
                return;
            }
            TryUpdateModel(pessoa);

            if (ModelState.IsValid)
            {
                // Save changes here, e.g. MyDataLayer.SaveChanges();
                db.SaveChanges();
            }
        }

        protected void PessoaID_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}