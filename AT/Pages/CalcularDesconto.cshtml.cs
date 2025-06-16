using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static AT.Services.DescontoService;

namespace AT.Pages
{
    public class CalcularDescontoModel : PageModel
    {
        [BindProperty]
        public decimal Valor { get; set; }
        public decimal? ValorComDesconto { get; set; }
        
        public void OnPost()
        {
            CalculateDelegate calcularDesconto = DarDesconto;
            ValorComDesconto = calcularDesconto(Valor);
        }
    }
}
