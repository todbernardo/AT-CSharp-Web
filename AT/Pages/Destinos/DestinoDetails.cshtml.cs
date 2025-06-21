using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages.Destinos
{
    public class DestinoDetailsModel : PageModel
    {
        public AtContext Context { get; set; }
        public Destino Destino { get; set; }
        public DestinoDetailsModel(AtContext context)
        {
            Context = context;
        }
        public void OnGet(int id)
        {
            Destino = Context.Destinos.FirstOrDefault(d => d.Id == id);
        }
    }
}
