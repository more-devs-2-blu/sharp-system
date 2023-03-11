using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities
{
    public class NFSE
    {
        public int Id { get; set; }
        public class NotaFiscal
        {
            public int Id { get; set; }

            [XmlElement("valor_total")]
            public string ValorTotal { get; set; }
        }
        public class Prestador
        {
            public int Id { get; set; }

            [XmlElement("cpfcnpj")]
            public string CpfCnpj { get; set; }

            [XmlElement("cidade")]
            public string Cidade { get; set; }
        }
        public class Tomador
        {
            public int Id { get; set; }

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
        public class Itens
        {
            public class Lista
            {
                public int Id { get; set; }

                [XmlElement("tributa_municipio_prestador")]
                public string TributaMunicipioPrestador { get; set; }

                [XmlElement("codigo_local_prestacao_servico")]
                public string CodigoLocalPrestacaoServico { get; set; }

                [XmlElement("codigo_item_lista_servico")]
                public string CodigoItemListaServico { get; set; }

                [XmlElement("descritivo")]
                public string Descritivo { get; set; }

                [XmlElement("aliquota_item_lista_servico")]
                public decimal AliquotaItemListaServico { get; set; }

                [XmlElement("situacao_tributaria")]
                public string SituacaoTributaria { get; set; }

                [XmlElement("valor_tributavel")]
                public string ValorTributavel { get; set; }
            }
        }
    }
}
