using SharpSystem.Domain.Entities.NF;
using SharpSystem.Domain.IRepositories.NFRepositories;
using SharpSystem.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Infra.Data.Repositories.NFRepositories
{
    public class PrestadorRepository : BaseRepository<Prestador>, IPrestadorRepository
    {
        private readonly SQLServerContext _context;
        public PrestadorRepository(SQLServerContext context) : base(context)
        {
            _context = context;
        }
    }
}
