using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities.NF
{
    public class Itens
    {
        public int Id { get; set; }
        public Lista ListaId { get; set; }
        public List<Lista> Lista { get; set; }


    }
}
