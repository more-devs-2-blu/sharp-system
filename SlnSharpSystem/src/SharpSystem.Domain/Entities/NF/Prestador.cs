using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
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