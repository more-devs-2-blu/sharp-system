using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IRepositories;
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
    }
}
