using AT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AT.Pages
{
    public class CreateClienteModel : PageModel
    {
        [BindProperty]
        public Cliente cliente { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Campo obrigat�rio.")]
        [MinLength(3, ErrorMessage = "M�nimo de 3 caracteres.")]
        public string Cidade { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                // Salvar cliente no banco
            }
        }
    }
}


