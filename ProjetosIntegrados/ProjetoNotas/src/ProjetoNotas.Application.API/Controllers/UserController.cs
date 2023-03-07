using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService service)
        {
            _userService = service;
        }
        [Route("[controller]")]
        public async Task<IActionResult> Index()
        {
            var list = _userService.FindAll();
            return View(list);
        }
        public JsonResult ListJson()
        {
            return Json(_userService.FindAll());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, login, senha, email")] UserDTO user)
        {
            if (ModelState.IsValid)
            {
                if (await _userService.Save(user) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
