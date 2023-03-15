using SharpSystem.Domain.Entities.NFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    public class TomadorDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("tipo")]
        public string tipo { get; set; }

        [XmlElement("cpfcnpj")]
        public string cpfCnpj { get; set; }

        [XmlElement("nome_razao_social")]
        public string nomeRazaoSocial { get; set; }

        [XmlElement("logradouro")]
        public string logradouro { get; set; }

        [XmlElement("email")]
        public string email { get; set; }

        [XmlElement("numero_residencia")]
        public string numeroResidencia { get; set; }

        [XmlElement("bairro")]
        public string bairro { get; set; }

        [XmlElement("cidade")]
        public string cidade { get; set; }

        [XmlElement("cep")]
        public string cep { get; set; }

        public TomadorDTO mapToDTO(Tomador tomador)
        {
            return new TomadorDTO
            {
                id = tomador.Id,
                cpfCnpj = tomador.CpfCnpj,
                tipo = tomador.Tipo,
                nomeRazaoSocial = tomador.NomeRazaoSocial,
                logradouro= tomador.Logradouro,
                email = tomador.Email,
                numeroResidencia = tomador.NumeroResidencia,
                bairro= tomador.Bairro,
                cidade = tomador.Cidade,
                cep= tomador.Cep,
            };
        }
        public Tomador mapToEntity()
        {
            return new Tomador()
            {
                Id= id,
                CpfCnpj= cpfCnpj,
                Tipo= tipo,
                NomeRazaoSocial= nomeRazaoSocial,
                Logradouro= logradouro,
                Email= email,
                NumeroResidencia= numeroResidencia,
                Bairro= bairro,
                Cep= cep,
                Cidade= cidade,
            };
        }
    }
}
