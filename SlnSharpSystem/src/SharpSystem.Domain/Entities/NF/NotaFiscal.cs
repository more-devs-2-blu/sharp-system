using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
    [Table("NotaFiscal")]
    [XmlRoot("nf")]
    public class NotaFiscal
    {
        [Column("id")]
        [XmlIgnoreAttribute]
        public int Id { get; set; }

        [Column("valorTotal")]
        [XmlElement("valor_total")]
        public string ValorTotal { get; set; }

        [Column("prestador")]
        [XmlElement("prestador")]
        public Prestador Prestador { get; set; }

        [Column("tomador")]
        [XmlElement("tomador")]
        public Tomador Tomador { get; set; }

        [Column("itens")]
        [XmlElement("Itens")]
        public Itens Itens { get; set; }

        [XmlIgnoreAttribute]
        public int PrestadorId { get; set; }
        [XmlIgnoreAttribute]
        public virtual Prestador? prestador { get; set; }

        [XmlIgnoreAttribute]
        public int TomadorId { get; set; }
        [XmlIgnoreAttribute]
        public virtual Tomador? tomador { get; set; }

        [XmlIgnoreAttribute]
        public int ItemId { get; set; }
        [XmlIgnoreAttribute]
        public virtual Itens? itens { get; set; }

    }
}
