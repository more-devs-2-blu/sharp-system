using SharpSystem.Domain.Entities.NF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO
{
    public class NFESDTO
    {
        [XmlElement("nf")]
        public NotaFiscal NF { get; set; }
        [XmlElement("prestador")]
        public Prestador Prestador { get; set; }
        [XmlElement("tomador")]
        public Tomador Tomador { get; set; }
        [XmlElement("itens")]
        public List<Prestador> Itens { get; set; }
    }
}
