using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
    [Table("itens")]
    [XmlRoot("itens")]
    public class Itens
    {
        [Column("id")]
        [XmlIgnoreAttribute]
        public int Id { get; set; }

        [XmlElement("lista")]
        public Lista Lista { get; set; }

        [XmlIgnoreAttribute]
        public int listaId { get; set; }
        [XmlIgnoreAttribute]
        public virtual Lista? lista { get; set; }

        [XmlIgnoreAttribute]
        public virtual ICollection<NotaFiscal> NotaFiscal { get; set; }
    }
}
