using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    public class NotalFiscalDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("valor_total")]
        public string valorTotal { get; set; }
    }
}

