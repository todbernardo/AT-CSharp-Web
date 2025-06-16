using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT.Pages
{
    public class CalcReservaModel : PageModel
    {
        [BindProperty]
        public int NumDiarias { get; set; }
        [BindProperty]
        public int ValorDiaria { get; set; }
        [BindProperty]
        public decimal? ValorTotal { get; set; }
        public void OnPost()
        {
            CalcularReserva CalcReserva;
            ValorTotal = CalcularReserva.CalcReserva(NumDiarias, ValorDiaria);
        }
    }
}
