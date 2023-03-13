using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly SQLServerContext _context;
        public UsuarioRepository(SQLServerContext context) 
            : base(context)
        {
            _context = context;
        }

        public Usuario BuscarEmailCNPJ(string email, string cpfcnpj)
        {
            return _context.Usuarios.FirstOrDefault(x => x.CFPCNPJ.ToUpper() == cpfcnpj.ToUpper() && x.Email.ToUpper() == email.ToUpper());
        }

        public Usuario BuscarLogin(string cpfcnpj)
        {
            return _context.Usuarios.FirstOrDefault(x => x.CFPCNPJ.ToUpper() == cpfcnpj.ToUpper());
        }
    }
}
