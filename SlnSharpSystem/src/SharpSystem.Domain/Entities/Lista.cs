using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities
{
    public class Lista
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
        public decimal AliquotaItemListaServico { get; set; }

        [XmlElement("situacao_tributaria")]
        public string SituacaoTributaria { get; set; }

        [XmlElement("valor_tributavel")]
        public string ValorTributavel { get; set; }
    }
}
