using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SharpSystem.Domain.Entities.NF;

namespace SharpSystem.Domain.Entities
{
    public class NFSE
    {
        [XmlElement("nf")]
        public NotaFiscal NF { get; set; }
        public Guid MyProperty { get; set; }
        [XmlElement("prestador")]
        public Prestador Prestador { get; set; }
        [XmlElement("tomador")]
        public Tomador Tomador { get; set; }
        [XmlElement("itens")]
        public List<Prestador> Itens { get; set; }
    }
}
