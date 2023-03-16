using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO.UsuarioDTO;
using SharpSystem.Domain.IServices;
using SharpSystem.Web.Models;
using System.Diagnostics;

namespace SharpSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsuarioService _service;
        public HomeController(ILogger<HomeController> logger, IUsuarioService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, nome, cpfcnpj, senha")] UsuarioDTO usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    TempData["MsgSucesso"] = "Usuário cadastrado com sucesso";
                    if (await _service.Save(usuario) > 0) return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MsgErro"] = $"Usuário não foi cadastrado corretamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}