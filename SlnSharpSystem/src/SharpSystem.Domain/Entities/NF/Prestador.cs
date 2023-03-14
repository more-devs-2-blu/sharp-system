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
    public class Prestador
    {
        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [XmlElement("cidade")]
        public string Cidade { get; set; }

    }
}
=======
    [Table("Prestador")]
    [XmlRoot("prestador")]
    public class Prestador
    {
        [Column("id")]
        [XmlIgnoreAttribute]
        public int Id { get; set; }

        [Column("cpfcnpj")]
        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [Column("cidade")]
        [XmlElement("cidade")]
        public string Cidade { get; set; }

        [XmlIgnoreAttribute]
        public virtual ICollection<NotaFiscal>? NotaFiscal { get; set; }
    }
}
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
