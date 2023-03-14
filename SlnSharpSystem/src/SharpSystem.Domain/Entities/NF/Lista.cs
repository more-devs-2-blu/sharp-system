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

<<<<<<< HEAD

namespace SharpSystem.Domain.Entities.NF
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
        public string AliquotaItemListaServico { get; set; }

        [XmlElement("situacao_tributaria")]
        public string SituacaoTributaria { get; set; }

        [XmlElement("valor_tributavel")]
        public string ValorTributavel { get; set; }

    }
}
=======
namespace SharpSystem.Domain.Entities.NF
{
    [Table("Listas")]
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
        public virtual ICollection<Itens>? Itens { get; set; }
    }
}
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
