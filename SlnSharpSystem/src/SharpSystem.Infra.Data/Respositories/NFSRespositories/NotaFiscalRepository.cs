using SharpSystem.Domain.Entities.NFS;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;

namespace SharpSystem.Infra.Data.Respositories.NFSRespositories
{
    public class NotaFiscalRepository : BaseRepository<NotaFiscal>, INotaFiscalRepository
    {
        private readonly SQLServerContext _context;
        public NotaFiscalRepository(SQLServerContext context) : base(context)
        {
            _context = context;
        }
    }
}
