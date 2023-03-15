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
    public class LoginRepository : BaseRepository<Login>, ILoginRepository
    {
        private readonly SQLServerContext _context;
        public LoginRepository(SQLServerContext context) : base(context)
        {
            _context = context;
        }

        public string ConversorBase64(string cpfcnpj, string senha)
        {
            string str = $"{cpfcnpj}:{senha}";
            byte[] encodedBytes = Encoding.UTF8.GetBytes(str);
            string encodedString = Convert.ToBase64String(encodedBytes);
            return encodedString;
        }
    }
}
