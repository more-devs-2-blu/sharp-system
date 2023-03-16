using SharpSystem.Domain.Entities.NFS;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;

namespace SharpSystem.Infra.Data.Respositories.NFSRespositories
{
    public class ListaRepository : BaseRepository<Lista>, IListaRepository
    {
        private readonly SQLServerContext _context;
        public ListaRepository(SQLServerContext context) : base(context)
        {
            _context = context;
        }
    }
}
