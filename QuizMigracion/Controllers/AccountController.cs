using Microsoft.AspNetCore.Mvc;
using ControlMigracion.Models;

namespace ControlMigracion.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí agregarías la lógica para validar el usuario y la contraseña
                if (model.NombreUsuario == "admin" && model.Contraseña == "1234")
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos.");
            }
            return View(model);
        }
    }
}
