using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IServices;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Xml;
using SharpSystem.Domain.Entities;
using SharpSystem.Domain.Entities.NF;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, nome, cpfcnpj, email, login, senha")] UsuarioDTO usuario)
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
    }
}
