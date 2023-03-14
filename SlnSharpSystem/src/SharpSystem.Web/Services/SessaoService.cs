using Newtonsoft.Json;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IServices;

namespace SharpSystem.Web.Services
{
    public class SessaoService : ISessaoService
    {
        private readonly IHttpContextAccessor _httpContext;

        public SessaoService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

<<<<<<< HEAD
        public UsuarioDTO BuscarSessaoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<UsuarioDTO>(sessaoUsuario);
=======
        public Usuario BuscarSessaoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
        }

        public void CriarSessaoUsuario(Usuario usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
