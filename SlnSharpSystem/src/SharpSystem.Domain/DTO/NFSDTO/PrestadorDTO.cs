using SharpSystem.Domain.Entities.NFS;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    public class PrestadorDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("cpfcnpj")]
        public string cpfCnpj { get; set; }

        [XmlElement("cidade")]
        public string cidade { get; set; }

        public PrestadorDTO mapToDTO(Prestador prestador)
        {
            return new PrestadorDTO()
            {
                id = prestador.Id,
                cpfCnpj = prestador.CpfCnpj,
                cidade = prestador.Cidade,
            };
        }
        public Prestador mapToEntity()
        {
            return new Prestador()
            {
                Id = id,
                CpfCnpj = cidade,
                Cidade = cidade,
            };
        }
    }
}
