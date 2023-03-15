using SharpSystem.Domain.Entities.NFS;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    public class NotalFiscalDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("valor_total")]
        public string valorTotal { get; set; }

        public NotalFiscalDTO mapToDTO(NotaFiscal notaFiscal)
        {
            return new NotalFiscalDTO()
            {
                id = notaFiscal.Id,
                valorTotal = notaFiscal.ValorTotal
            };
        }
        public NotaFiscal mapToEntity()
        {
            return new NotaFiscal()
            {
                Id = id,
                ValorTotal = valorTotal
            };
        }
    }
}

