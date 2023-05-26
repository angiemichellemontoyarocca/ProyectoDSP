using Microsoft.AspNetCore.Mvc;
using ProyectoDSP.Models;
using ProyectoDSP.Services;

namespace ProyectoDSP.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICita _cita;

        public IActionResult Index()
        {
            return View(_cita.GetAllCitas());
        }
        [Route("Cita/Eliminar/{id}")]
        public IActionResult Eliminar(string id)
        {
            _cita.remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult Nuevo()
        {
            return View();
        }
        public IActionResult Grabar(citas obj)
        {
            _cita.add(obj);
            return RedirectToAction("Index");
        }
        [Route("Distrito/Modificar/{id}")]
        public IActionResult Modificar(string id)
        {
            return View(_cita.edit(id));
        }
        public IActionResult Modificarcita(citas obj)
        {
            _cita.editDetails(obj);
            return RedirectToAction("Index");
        }
    }
}
