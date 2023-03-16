using SharpSystem.Domain.Entities.NFS;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    public class ListaDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("tributa_municipio_prestador")]
        public string tributaMunicipioPrestador { get; set; }

        [XmlElement("codigo_local_prestacao_servico")]
        public string codigoLocalPrestacaoServico { get; set; }

        [XmlElement("codigo_item_lista_servico")]
        public string codigoItemListaServico { get; set; }

        [XmlElement("descritivo")]
        public string descritivo { get; set; }

        [XmlElement("aliquota_item_lista_servico")]
        public string aliquotaItemListaServico { get; set; }

        [XmlElement("situacao_tributaria")]
        public string situacaoTributaria { get; set; }

        [XmlElement("valor_tributavel")]
        public string valorTributavel { get; set; }

        public ListaDTO mapToDTO(Lista lista)
        {
            return new ListaDTO()
            {
                id = lista.Id,
                tributaMunicipioPrestador = lista.TributaMunicipioPrestador,
                codigoLocalPrestacaoServico = lista.CodigoLocalPrestacaoServico,
                codigoItemListaServico = lista.CodigoItemListaServico,
                descritivo = lista.Descritivo,
                aliquotaItemListaServico = lista.AliquotaItemListaServico,
                situacaoTributaria = lista.SituacaoTributaria,
                valorTributavel = lista.ValorTributavel,
            };
        }
        public Lista mapToEntity()
        {
            return new Lista()
            {
                Id = id,
                TributaMunicipioPrestador = tributaMunicipioPrestador,
                CodigoLocalPrestacaoServico = codigoLocalPrestacaoServico,
                CodigoItemListaServico = codigoItemListaServico,
                Descritivo = descritivo,
                AliquotaItemListaServico = aliquotaItemListaServico,
                SituacaoTributaria = situacaoTributaria,
                ValorTributavel = valorTributavel,
            };
        }
    }
}
