using SharpSystem.Domain.DTO.NFSDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NFS
{
    public class Lista
    {
        public int Id { get; set; }
        public string TributaMunicipioPrestador { get; set; }
        public string CodigoLocalPrestacaoServico { get; set; }
        public string CodigoItemListaServico { get; set; }
        public string Descritivo { get; set; }
        public string AliquotaItemListaServico { get; set; }
        public string SituacaoTributaria { get; set; }
        public string ValorTributavel { get; set; }
        public ListaDTO mapToDTO()
        {
            return new ListaDTO()
            {
                id = Id,
                tributaMunicipioPrestador = TributaMunicipioPrestador,
                codigoLocalPrestacaoServico = CodigoLocalPrestacaoServico,
                codigoItemListaServico = CodigoItemListaServico,
                descritivo = Descritivo,
                aliquotaItemListaServico = AliquotaItemListaServico,
                situacaoTributaria = SituacaoTributaria,
                valorTributavel = ValorTributavel,
            };
        }
    }
}
