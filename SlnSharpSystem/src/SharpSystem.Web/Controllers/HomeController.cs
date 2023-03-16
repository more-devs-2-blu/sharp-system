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
        public HomeController(IUsuarioService service, ILogger<HomeController> logger)
        {
            _service = service;
            logger = logger;
        }

        [Route("")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ValidLogin(UsuarioDTO user)
        {

            var loginList = _service.FindAll();
            if (loginList.Any())
            {
                UsuarioDTO result = loginList.FirstOrDefault();
                if (result.cpfcnpj == user.cpfcnpj && result.senha == user.senha)
                {
                    return RedirectToAction("Index", "NFSE");
                }
            }
            TempData["Incorrect Login"] = "Invalid User";
            return RedirectToAction("Index", "Home");
        }
        [Route("cadastro")]
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
                    if (await _service.Save(usuario) > 0) return RedirectToAction("Index","NFSE");
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MsgErro"] = $"Usuário não foi cadastrado corretamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}