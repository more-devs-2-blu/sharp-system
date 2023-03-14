using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
<<<<<<< HEAD
    public class Itens
    {
        [XmlElement("lista")]
        public Lista Lista { get; set; }
    }
}
=======
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
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
