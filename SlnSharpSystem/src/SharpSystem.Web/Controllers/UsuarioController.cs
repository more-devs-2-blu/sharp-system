using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IServices;

namespace SharpSystem.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View(_service.FindAll());
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro([Bind("id, nome, cpfcnpj, email, login, senha")] UsuarioDTO usuario)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(usuario) > 0) return RedirectToAction("Index");
            }
            return View(usuario);
        }
    }
}
