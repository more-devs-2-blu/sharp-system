using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IServices.INFSServices;

namespace SharpSystem.Application.SQLServerServices.NFSServices
{
    public class ListaService : IListaService
    {
        private readonly IListaRepository _listaRepository;
        public ListaService(IListaRepository listaRepository)
        {
            _listaRepository = listaRepository;
        }
        public Task<int> Save(ListaDTO entity)
        {
            if (entity.id > 0)
            {
                return _listaRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _listaRepository.Save(entity.mapToEntity());
            }
        }
        public List<ListaDTO> FindAll()
        {
            return _listaRepository.FindAll()
                .Select(c => new ListaDTO()
                {
                    id = c.Id,
                    tributaMunicipioPrestador = c.TributaMunicipioPrestador,
                    codigoLocalPrestacaoServico = c.CodigoLocalPrestacaoServico,
                    codigoItemListaServico = c.CodigoItemListaServico,
                    descritivo = c.Descritivo,
                    aliquotaItemListaServico = c.AliquotaItemListaServico,
                    situacaoTributaria = c.SituacaoTributaria,
                    valorTributavel = c.ValorTributavel,
                }).ToList();
        }
        public async Task<ListaDTO> FindById(int id)
        {
            var dto = new ListaDTO();
            return dto.mapToDTO(await _listaRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _listaRepository.FindById(id);
            return await _listaRepository.Delete(entity);
        }
    }
}
