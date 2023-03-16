using SharpSystem.Domain.Entities.NFS;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Infra.Data.Context;
using SharpSystem.Infra.Data.Repositories;

namespace SharpSystem.Infra.Data.Respositories.NFSRespositories
{
    public class TomadorRespository : BaseRepository<Tomador>, ITomadorRespository
    {
        private readonly SQLServerContext _context;
        public TomadorRespository(SQLServerContext context) : base(context)
        {
            _context = context;
        }
    }
}
