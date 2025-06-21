using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace AT.Pages.Autenticacao
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Senha { get; set; }

        public string ErrorMessage { get; set; } = "Login inválido.";

        public async Task<IActionResult> OnPostAsync()
        {
            if (Usuario == "admin" && Senha == "123")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, Usuario)
                };

                var identidade = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identidade);

                await HttpContext.SignInAsync("MyCookieAuth", principal);
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
1