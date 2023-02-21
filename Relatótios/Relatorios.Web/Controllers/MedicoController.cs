using Microsoft.AspNetCore.Mvc;

namespace Relatorios.Web.Controllers
{
    public class MedicoController : Controller
    {
        /*private readonly IDoctorService _service;*/
        public MedicoController() { }
        public IActionResult Index()
        {
            return View();
        }
    }
}
