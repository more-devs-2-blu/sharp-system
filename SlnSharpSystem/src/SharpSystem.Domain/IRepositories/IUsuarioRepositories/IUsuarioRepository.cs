using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.IRepositories.IUsuarioRepositories
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        UsuarioDTO BuscarLogin(string cpfcnpj);
        UsuarioDTO BuscarEmailCNPJ(string email, string cpfcnpj);
    }
}
