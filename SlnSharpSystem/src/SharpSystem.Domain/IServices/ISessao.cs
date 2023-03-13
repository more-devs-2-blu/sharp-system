using SharpSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.IServices
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioDTO usuario);
        void RemoverSessaoUsuario();
        UsuarioDTO BuscarSessaoUsuario();
    }
}
