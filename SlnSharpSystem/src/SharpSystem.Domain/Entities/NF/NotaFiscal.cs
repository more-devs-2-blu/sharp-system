using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
<<<<<<< HEAD
    public class NotaFiscal
    {
        [XmlElement("valor_total")]
        public string ValorTotal { get; set; }
        public Prestador Prestador { get; set; }
        public Tomador Tomador { get; set; }
        public List<Itens> Lista { get; set; }
    }
}
=======
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
        public virtual Prestador? prestador { get; set; }

        [Column("tomador")]
        [XmlElement("tomador")]
        public virtual Tomador? tomador { get; set; }

        [Column("itens")]
        [XmlElement("Itens")]
        public virtual Itens? itens { get; set; }
        [XmlIgnoreAttribute]
        public int PrestadorId { get; set; }
        [XmlIgnoreAttribute]
        public int TomadorId { get; set; }
        [XmlIgnoreAttribute]
        public int ItemId { get; set; }

    

    }
}
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
