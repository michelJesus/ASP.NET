using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_DropdownLists.Controllers
{
    public static class Conversor
    {
        public static SelectList ToSelectList(
              this IEnumerable<Habito> habitos, int selectedId)
        {
            return new SelectList(habitos.OrderBy(habito => habito.Descricao)
                .Select(habito => new SelectListItem
                {
                    Selected = (habito.Id == selectedId),
                    Value = habito.Id.ToString(),
                    Text = habito.Descricao
                }), "Value", "Text");
        }

        public static IEnumerable<SelectListItem> ToSelectListItems(
              this IEnumerable<Habito> habitos, int selectedId)
        {
            return habitos.OrderBy(habito => habito.Descricao)
                .Select(habito => new SelectListItem
                {
                    Selected = (habito.Id == selectedId),
                    Value = habito.Id.ToString(),
                    Text = habito.Descricao
                });
        }  
    }
}