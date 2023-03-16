using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IServices.INFSServices;

namespace SharpSystem.Application.SQLServerServices.NFSServices
{
    public class ItensService : IItensService
    {
        private readonly IItensRepository _itensRepository;
        public ItensService(IItensRepository itensRepository)
        {
            _itensRepository = itensRepository;
        }
        public Task<int> Save(ItensDTO entity)
        {
            if (entity.id > 0)
            {
                return _itensRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _itensRepository.Save(entity.mapToEntity());
            }
        }
        public List<ItensDTO> FindAll()
        {
            return _itensRepository.FindAll()
                .Select(c => new ItensDTO()
                {
                    id = c.Id,
                    listaDTO = new ListaDTO()
                    {
                        id = c.lista.Id,
                        tributaMunicipioPrestador = c.lista.TributaMunicipioPrestador,
                        codigoLocalPrestacaoServico = c.lista.CodigoLocalPrestacaoServico,
                        codigoItemListaServico = c.lista.CodigoItemListaServico,
                        descritivo = c.lista.Descritivo,
                        aliquotaItemListaServico = c.lista.AliquotaItemListaServico,
                        situacaoTributaria = c.lista.SituacaoTributaria,
                        valorTributavel = c.lista.ValorTributavel,
                    }
                }).ToList();
        }
        public async Task<ItensDTO> FindById(int id)
        {
            var dto = new ItensDTO();
            return dto.mapToDTO(await _itensRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _itensRepository.FindById(id);
            return await _itensRepository.Delete(entity);
        }
    }
}
