using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IServices.INFSServices;

namespace SharpSystem.Application.SQLServerServices.NFSServices
{
    public class PrestadorService : IPrestadorService
    {
        private readonly IPrestadorRepository _prestadorRepository;
        public PrestadorService(IPrestadorRepository prestadorRepository)
        {
            _prestadorRepository = prestadorRepository;
        }
        public Task<int> Save(PrestadorDTO entity)
        {
            if (entity.id > 0)
            {
                return _prestadorRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _prestadorRepository.Save(entity.mapToEntity());
            }
        }
        public List<PrestadorDTO> FindAll()
        {
            return _prestadorRepository.FindAll()
                .Select(c => new PrestadorDTO()
                {
                    id = c.Id,
                    cpfCnpj = c.CpfCnpj,
                    cidade = c.Cidade,
                }).ToList();
        }
        public async Task<PrestadorDTO> FindById(int id)
        {
            var dto = new PrestadorDTO();
            return dto.mapToDTO(await _prestadorRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _prestadorRepository.FindById(id);
            return await _prestadorRepository.Delete(entity);
        }
    }
}
