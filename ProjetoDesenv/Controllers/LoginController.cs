using Microsoft.AspNetCore.Mvc;

namespace ProjetoDesenv.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Logar()
        {
            return View();
        }
    }
}
