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
<<<<<<< HEAD
=======
using SharpSystem.Web.Models;
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef

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
<<<<<<< HEAD
        public async Task<IActionResult> Create([Bind("id, nome, cpfcnpj, email, login, senha")] UsuarioDTO usuario)
=======
        public async Task<IActionResult> Create([Bind("id, nome, cpfcnpj, senha")] UsuarioD usuario)
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
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
<<<<<<< HEAD
=======

        public async Task<IActionResult> Edit(int id)
        {
            var usuario = await _service.FindById(id);
            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int? id, [Bind("id, nome, cpfcnpj, senha")] UsuarioDTO usuario)
        {
            if (id != usuario.id) return NotFound();

            try
            {
                if (ModelState.IsValid)
                {
                    if (await _service.Save(usuario) > 0) return RedirectToAction(nameof(Index));
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MsgErro"] = $"Usuário não foi alterado corretamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
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
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
    }
}
