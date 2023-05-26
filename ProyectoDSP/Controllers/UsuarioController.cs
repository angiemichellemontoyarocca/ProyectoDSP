using Microsoft.AspNetCore.Mvc;
using ProyectoDSP.Models;
using ProyectoDSP.Services;

namespace ProyectoDSP.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario _usuario;
        public UsuarioController(IUsuario usuario)
        {
            _usuario = usuario;
        }
        [Route("/")]
        [Route("principal")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("usuario/Registro")]
        public IActionResult Registro()
        {
            return View();
        }
        [Route("usuario/Listar")]
        public IActionResult Listar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuario.Add(usuario);
                var lst = _usuario.Listuser();
                return View(lst);
            }
            else
            {
                return View("Registro");
            }

        }
    }
}
