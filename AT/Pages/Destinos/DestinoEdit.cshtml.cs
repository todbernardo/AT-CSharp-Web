using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AT.Pages.Destinos
{
    public class DestinoEditModel : PageModel
    {
        private readonly AtContext _context;

        public DestinoEditModel(AtContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Destino Destino { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Destino = await _context.Destinos.FindAsync(id);

            if (Destino == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Destino).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return RedirectToPage("DestinoIndex");
        }
    }
}