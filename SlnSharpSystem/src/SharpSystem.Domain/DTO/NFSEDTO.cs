using SharpSystem.Domain.Entities.NF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace SharpSystem.Domain.DTO
{
    [XmlRoot("nfse")]
    public class NFSEDTO
    {
        [XmlElement("nf")]
        public NotaFiscal notaFiscal { get; set; }
        
        [XmlElement("prestador")]
        public Prestador prestador { get; set; }
        
        [XmlElement("tomador")]
        public Tomador tomador { get; set; }

        [XmlElement("itens")]
        public Itens itens { get; set; }

        
    }
}