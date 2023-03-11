using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Helper
{
    public class SessaoRepository : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public SessaoRepository(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;     
        }

        public Usuario BuscarSessaoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<Usuario>(sessaoUsuario);
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
