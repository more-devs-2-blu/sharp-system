using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities
{
    public class Prestador
    {
        public int Id { get; set; }
        public string CpfCnpj { get; set; }
        public string Cidade { get; set; }
    }
}
