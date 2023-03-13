using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
    public class Prestador
    {
        public int Id { get; set; }

        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [XmlElement("cidade")]
        public string Cidade { get; set; }

    }
}
