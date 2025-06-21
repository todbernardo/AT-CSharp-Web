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
        [Required(ErrorMessage = "Campo obrigatório.")]
        [MinLength(3, ErrorMessage = "Mínimo de 3 caracteres.")]
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


