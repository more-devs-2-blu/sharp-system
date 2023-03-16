using SharpSystem.Domain.Entities.NFS;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;

namespace SharpSystem.Infra.Data.Respositories.NFSRespositories
{
    public class ItensRepository : BaseRepository<Itens>, IItensRepository
    {
        private readonly SQLServerContext _context;
        public ItensRepository(SQLServerContext context) : base(context)
        {
            _context = context;
        }
    }
}
