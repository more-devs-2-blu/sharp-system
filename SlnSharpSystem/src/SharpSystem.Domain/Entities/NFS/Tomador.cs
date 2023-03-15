using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NFS
{
    public class Tomador
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string CpfCnpj { get; set; }
        public string NomeRazaoSocial { get; set; }
        public string Logradouro { get; set; }
        public string Email { get; set; }
        public string NumeroResidencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
    }
}
