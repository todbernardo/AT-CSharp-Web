using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages.Destinos
{
    public class CreateDestinoModel : PageModel
    {
        [BindProperty]
        public Destino destino { get; set; }
        public AtContext Context;

        public CreateDestinoModel(AtContext context)
        {
            Context = context;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Context.Destinos.Add(destino);
                Context.SaveChanges();
                return RedirectToPage("DestinoIndex");
            }
            return Page();
        }
    }
}
