using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities.NFS
{
    public class NFSE
    {
        public int Id { get; set; }
        public NotaFiscal notaFiscal { get; set; }
        public Prestador prestador { get; set; }
        public Tomador tomador { get; set; }
    }
}
