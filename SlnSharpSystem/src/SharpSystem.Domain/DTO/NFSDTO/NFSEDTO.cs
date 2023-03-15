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
    }
}
