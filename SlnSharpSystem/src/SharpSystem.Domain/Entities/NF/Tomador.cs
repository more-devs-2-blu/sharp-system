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
    public class Tomador
    {
        [XmlElement("tipo")]
        public string Tipo { get; set; }

        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [XmlElement("nome_razao_social")]
        public string NomeRazaoSocial { get; set; }

        [XmlElement("logradouro")]
        public string Logradouro { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("numero_residencia")]
        public string NumeroResidencia { get; set; }

        [XmlElement("bairro")]
        public string Bairro { get; set; }

        [XmlElement("cidade")]
        public string Cidade { get; set; }

        [XmlElement("cep")]
        public string Cep { get; set; }

    }
}
=======
    [Table("tomador")]
    [XmlRoot("tomador")]
    public class Tomador
    {
        [Column("id")]
        [XmlIgnoreAttribute]
        public int Id { get; set; }

        [Column("tipo")]
        [XmlElement("tipo")]
        public string Tipo { get; set; }

        [Column("cpfcnpj")]
        [XmlElement("cpfcnpj")]
        public string CpfCnpj { get; set; }

        [Column("nomeRazaoSocial")]
        [XmlElement("nome_razao_social")]
        public string NomeRazaoSocial { get; set; }

        [Column("logradouro")]
        [XmlElement("logradouro")]
        public string Logradouro { get; set; }

        [Column("email")]
        [XmlElement("email")]
        public string Email { get; set; }

        [Column("numeroResidencia")]
        [XmlElement("numero_residencia")]
        public string NumeroResidencia { get; set; }

        [Column("bairro")]
        [XmlElement("bairro")]
        public string Bairro { get; set; }

        [Column("cidade")]
        [XmlElement("cidade")]
        public string Cidade { get; set; }

        [Column("cep")]
        [XmlElement("cep")]
        public string Cep { get; set; }

        [XmlIgnoreAttribute]
        public virtual ICollection<NotaFiscal>? NotaFiscal { get; set; }
    }
}
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
