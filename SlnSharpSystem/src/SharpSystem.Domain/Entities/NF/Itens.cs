using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
    [Table("Itens")]
    [XmlRoot("itens")]
    public class Itens
    {
        [Column("id")]
        [XmlIgnoreAttribute]
        public int Id { get; set; }

        [XmlIgnoreAttribute]
        public int listaId { get; set; }
        [XmlElement("lista")]
        public virtual Lista? Lista { get; set; }

        [XmlIgnoreAttribute]
        public virtual ICollection<NotaFiscal>? NotaFiscal { get; set; }
    }
}