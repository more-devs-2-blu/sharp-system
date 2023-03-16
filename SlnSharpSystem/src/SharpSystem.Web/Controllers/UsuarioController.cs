using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO.UsuarioDTO;
using SharpSystem.Domain.IServices;
using SharpSystem.Web.Models;

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
        public async Task<IActionResult> Edit(int id)
        {
            var usuario = await _service.FindById(id);
            return View(usuario);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, nome, cpfcnpj, senha")] UsuarioDTO usuario)
        {
            if (id != usuario.id) return NotFound();

            if (ModelState.IsValid)
            {
                if (await _service.Save(usuario) > 0) return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
        [HttpPost]
        public async Task<JsonResult> Delete(int? id)
        {
            var retDel = new ReturnJsonDel
            {
                status = "Success",
                code = "200"
            };
            if (await _service.Delete(id ?? 0) <= 0)
            {
                retDel = new ReturnJsonDel
                {
                    status = "Error",
                    code = "400"
                };
            }
            return Json(retDel);
        }
    }
}
