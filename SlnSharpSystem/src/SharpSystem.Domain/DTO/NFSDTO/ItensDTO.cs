using SharpSystem.Domain.Entities.NFS;
using System.Xml.Serialization;

namespace SharpSystem.Domain.DTO.NFSDTO
{
    public class ItensDTO
    {
        [XmlIgnore]
        public int id { get; set; }
        [XmlElement("lista")]
        public ListaDTO listaDTO { get; set; }
        public ItensDTO mapToDTO(Itens itens)
        {
            return new ItensDTO()
            {
                id = itens.Id,
                listaDTO = listaDTO.mapToDTO(itens.lista)
            };
        }
        public Itens mapToEntity()
        {
            return new Itens()
            {
                Id = id,
                lista = listaDTO.mapToEntity()
            };
        }
    }
}
