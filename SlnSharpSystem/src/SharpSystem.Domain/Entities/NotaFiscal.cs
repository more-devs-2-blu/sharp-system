using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities
{
    public class NotaFiscal
    {
        public int Id { get; set; }
        public string ValorTotal { get; set; }

        [XmlElement("prestador")]
        public Prestador Prestador { get; set; }

        [XmlElement("tomador")]
        public Tomador Tomador { get; set; }

        [XmlElement("itens")]
        public Itens Itens { get; set; }
    }
}
