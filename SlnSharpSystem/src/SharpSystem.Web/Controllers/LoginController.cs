using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Domain.IServices;

namespace SharpSystem.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepository _repository;
        private readonly ISessaoService _service;

        public LoginController(IUsuarioRepository repository, ISessaoService service)
        {
            _repository = repository;
            _service = service;
        }

        public IActionResult Index()
        {
            if(_service.BuscarSessaoUsuario() != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Sair()
        {
            _service.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Usuario usuario = _repository.BuscarLogin(login.CFPCNPJ);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(login.Senha))
                        {
                            _service.CriarSessaoUsuario(usuario);
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MsgErro"] = $"Senha do usuário incorreta. Por favor, tente novamente";
                    }
                    TempData["MsgErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente";
                }
                return View();
            }
            catch (Exception erro)
            {
                TempData["MsgErro"] = $"Não conseguimos realizar o seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
