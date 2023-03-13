using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Domain.Entities.NF
{
    [Table("listas")]
    [XmlRoot("lista")]
    public class Lista
    {
        [Column("id")]
        [XmlIgnoreAttribute]
        public int Id { get; set; }

        [Column("tributaMunicipioPrestador")]
        [XmlElement("tributa_municipio_prestador")]
        public string TributaMunicipioPrestador { get; set; }

        [Column("codigoLocalPrestacaoServio")]
        [XmlElement("codigo_local_prestacao_servico")]
        public string CodigoLocalPrestacaoServico { get; set; }

        [Column("codigoItemListaServico")]
        [XmlElement("codigo_item_lista_servico")]
        public string CodigoItemListaServico { get; set; }

        [Column("descritivo")]
        [XmlElement("descritivo")]
        public string Descritivo { get; set; }

        [Column("aliquotaItemListaServico")]
        [XmlElement("aliquota_item_lista_servico")]
        public string AliquotaItemListaServico { get; set; }

        [Column("situacaoTributaria")]
        [XmlElement("situacao_tributaria")]
        public string SituacaoTributaria { get; set; }

        [Column("valorTributavel")]
        [XmlElement("valor_tributavel")]
        public string ValorTributavel { get; set; }


        [XmlIgnoreAttribute]
        public virtual ICollection<Itens> Itens { get; set; }
    }
}
