using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities
{
    public class Lista
    {
        public int Id { get; set; }
        public string TribunaMunicipioPrestador { get; set; }
        public string CodigoLocalPrestacaoServico { get; set; }
        public string CodigoItemListaServico { get; set; }
        public string Descritivo { get; set; }
        public string AliquotaItemListaServico { get; set; }
        public string SituacaoTributaria { get; set; }
        public string ValorTributavel { get; set; }
    }
}
