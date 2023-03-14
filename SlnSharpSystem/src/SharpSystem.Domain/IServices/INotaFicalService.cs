using SharpSystem.Domain.DTO.NFDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.IServices
{
    public interface INotaFicalService : IBaseService<NFSEDTO>
    {
        public Task SendXML(string Base64, string path, string name);
    }
}
