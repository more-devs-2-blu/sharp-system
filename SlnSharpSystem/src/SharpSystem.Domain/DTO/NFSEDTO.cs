using SharpSystem.Domain.Entities.NF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
<<<<<<< HEAD
=======
using static System.Net.Mime.MediaTypeNames;
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef

namespace SharpSystem.Domain.DTO
{
    [XmlRoot("nfse")]
    public class NFSEDTO
    {
        [XmlElement("nf")]
        public NotaFiscal notaFiscal { get; set; }
<<<<<<< HEAD
        [XmlElement("prestador")]
        public Prestador prestador { get; set; }
        [XmlElement("tomador")]
        public Tomador tomador { get; set; }
        [XmlElement("itens")]
        public Itens itens { get; set; }
    
        public class ListaDTO
        {
            [XmlElement("tributa_municipio_prestador")]
            public string TributaMunicipioPrestador { get; set; }

            [XmlElement("codigo_local_prestacao_servico")]
            public string CodigoLocalPrestacaoServico { get; set; }

            [XmlElement("codigo_item_lista_servico")]
            public string CodigoItemListaServico { get; set; }

            [XmlElement("descritivo")]
            public string Descritivo { get; set; }

            [XmlElement("aliquota_item_lista_servico")]
            public string AliquotaItemListaServico { get; set; }

            [XmlElement("situacao_tributaria")]
            public string SituacaoTributaria { get; set; }

            [XmlElement("valor_tributavel")]
            public string ValorTributavel { get; set; }
        }
        //public class Prestador
        //{
        //    [XmlElement("cpfcnpj")]
        //    public string cpfcnpj { get; set; }

        //    [XmlElement("cidade")]
        //    public string cidade { get; set; }
        //}

        //public class Tomador
        //{
        //    [XmlElement("tipo")]
        //    public string tipo { get; set; }

        //    [XmlElement("cpfcnpj")]
        //    public string cpfcnpj { get; set; }

        //    [XmlElement("nome_razao_social")]
        //    public string nomeRazaoSocial { get; set; }

        //    [XmlElement("logradouro")]
        //    public string logradouro { get; set; }

        //    [XmlElement("email")]
        //    public string email { get; set; }

        //    [XmlElement("numero_residencia")]
        //    public string numeroResidencia { get; set; }

        //    [XmlElement("bairro")]
        //    public string bairro { get; set; }

        //    [XmlElement("cidade")]
        //    public string cidade { get; set; }

        //    [XmlElement("cep")]
        //    public string cep { get; set; }
        //}




        //public NFSEDTO mapToDTO(NotaFiscal nfs)
        //{
        //    return new NFSEDTO()
        //    {
        //        valorTotal = nfs.ValorTotal,
        //        prestador = new Prestador()
        //        {
        //            Cidade = nfs.Prestador.Cidade,
        //            CpfCnpj = nfs.Prestador.CpfCnpj
        //        },
        //        tomador = new Tomador()
        //        {
        //            Tipo = nfs.Tomador.Tipo,
        //            CpfCnpj = nfs.Tomador.CpfCnpj,
        //            NomeRazaoSocial = nfs.Tomador.NomeRazaoSocial,
        //            Logradouro = nfs.Tomador.Logradouro,
        //            Email = nfs.Tomador.Email,
        //            NumeroResidencia = nfs.Tomador.NumeroResidencia,
        //            Bairro = nfs.Tomador.Bairro,
        //            Cidade = nfs.Tomador.Cidade,
        //            Cep = nfs.Tomador.Cep
        //        }
        //        Itens = new Itens()
        //        {
        //            Lista = new Lista()
        //            {
        //            }
        //        }
        //    };
        //}
    }
}
=======
        
        [XmlElement("prestador")]
        public Prestador prestador { get; set; }
        
        [XmlElement("tomador")]
        public Tomador tomador { get; set; }

        [XmlElement("itens")]
        public Itens itens { get; set; }

        
    }
}
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
