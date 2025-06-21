using AT.Data;
using AT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace AT.Pages.Destinos
{
    [Authorize]
    public class DestinoIndexModel : PageModel
    {
        private readonly AtContext _context;
        public DestinoIndexModel(AtContext context)
        {
            _context = context;
        }

        public List<Destino> Destinos { get; set; }

        public async Task OnGetAsync()
        {
            Destinos = await _context.Destinos
                .Where(d => !d.IsDeleted) 
                .ToListAsync();
        }
        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var destino = await _context.Destinos.FindAsync(id);

            if (destino != null)
            {
                destino.IsDeleted = true;
                await _context.SaveChangesAsync();
            }
            return RedirectToPage();
        }
    }
}