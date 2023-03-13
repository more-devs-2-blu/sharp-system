using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
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
