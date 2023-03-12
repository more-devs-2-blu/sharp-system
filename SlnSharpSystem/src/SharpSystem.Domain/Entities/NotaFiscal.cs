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

        [XmlElement("valor_total")]
        public string ValorTotal { get; set; }

        
    }
}
