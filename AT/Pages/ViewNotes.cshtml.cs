using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace AT.Pages
{
    public class ViewNotesModel : PageModel
    {
        private readonly IWebHostEnvironment _env;

        public ViewNotesModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        [BindProperty]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string NomeArquivo { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Conteudo { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ArquivoSelecionado { get; set; }
        public string? ConteudoArquivo { get; set; }
        public List<string> Arquivos { get; set; } = new();
        public string NotaSalva { get; set; }

        public void OnGet()
        {
            CarregarArquivos();

            if (!string.IsNullOrEmpty(ArquivoSelecionado))
            {
                var caminho = Path.Combine(_env.WebRootPath, "files", Path.GetFileName(ArquivoSelecionado));
                if (System.IO.File.Exists(caminho))
                {
                    ConteudoArquivo = System.IO.File.ReadAllText(caminho);
                }
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                CarregarArquivos();
                return Page();
            }

            var caminho = Path.Combine(_env.WebRootPath, "files", Path.GetFileName(NomeArquivo));

            System.IO.File.WriteAllText(caminho, Conteudo);

            NotaSalva = $"Nota salva - '{NomeArquivo}.txt'";
            CarregarArquivos();

            return Page();
        }

        private void CarregarArquivos()
        {
            var dir = Path.Combine(_env.WebRootPath, "files");
            if (Directory.Exists(dir))
            {
                Arquivos = Directory
                    .GetFiles(dir, "*.txt")
                    .Select(Path.GetFileName)
                    .ToList();
            }
        }
    }
}