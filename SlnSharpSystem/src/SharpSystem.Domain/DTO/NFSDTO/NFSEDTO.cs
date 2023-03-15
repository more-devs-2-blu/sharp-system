using SharpSystem.Domain.Entities.NFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    [XmlRoot("nfse")]
    public class NFSEDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("nf")]
        public NotalFiscalDTO notaFiscalDTO { get; set; }
        [XmlElement("prestador")]
        public PrestadorDTO prestador { get; set; }
        [XmlElement("tomador")]
        public TomadorDTO tomador { get; set; }
        [XmlElement("itens")]
        public ItensDTO itens { get; set; }

        public NFSEDTO mapToDTO(NFSE nfse)
        {
            return new NFSEDTO()
            {
                id = nfse.Id,
                notaFiscalDTO = notaFiscalDTO.mapToDTO(nfse.NotaFiscal),
                prestador = prestador.mapToDTO(nfse.Prestador),
                tomador = tomador.mapToDTO(nfse.Tomador),
                itens = itens.mapToDTO(nfse.Itens),
            };
        }
        public NFSE mapToEntity()
        {
            return new NFSE()
            {
                Id = id,
                NotaFiscal = notaFiscalDTO.mapToEntity(),
                Prestador = prestador.mapToEntity(),
                Tomador = tomador.mapToEntity(),
                Itens = itens.mapToEntity(),
            };
        }

    }
}
