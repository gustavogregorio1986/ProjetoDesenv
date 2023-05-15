using Microsoft.AspNetCore.Mvc;

namespace ProjetoDesenv.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
