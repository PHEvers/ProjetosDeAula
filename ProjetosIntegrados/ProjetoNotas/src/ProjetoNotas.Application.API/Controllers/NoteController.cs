using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.Application.API.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }
        public IActionResult Index()
        {
            var listNoteUser = _noteService.FindAll();
            return View();
        }
    }
}
