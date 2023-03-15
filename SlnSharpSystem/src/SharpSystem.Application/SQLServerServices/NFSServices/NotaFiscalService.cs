using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IServices.INFSServices;

namespace SharpSystem.Application.SQLServerServices.NFSServices
{
    public class NotaFiscalService : INotaFicaslService
    {
        private readonly INotaFiscalRepository _notaFiscalRepository;
        public NotaFiscalService(INotaFiscalRepository notaFiscalRepository)
        {
            _notaFiscalRepository = notaFiscalRepository;
        }
        public Task<int> Save(NotaFiscalDTO entity)
        {
            if (entity.id > 0)
            {
                return _notaFiscalRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _notaFiscalRepository.Save(entity.mapToEntity());
            }
        }
        public List<NotaFiscalDTO> FindAll()
        {
            return _notaFiscalRepository.FindAll()
                .Select(c => new NotaFiscalDTO()
                {
                    id = c.Id,
                    valorTotal = c.ValorTotal,
                }).ToList();
        }
        public async Task<NotaFiscalDTO> FindById(int id)
        {
            var dto = new NotaFiscalDTO();
            return dto.mapToDTO(await _notaFiscalRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _notaFiscalRepository.FindById(id);
            return await _notaFiscalRepository.Delete(entity);
        }
    }
}
