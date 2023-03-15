using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Infra.Data.Context;

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
