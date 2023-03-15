using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IServices.INFSServices;

namespace SharpSystem.Application.SQLServerServices.NFSServices
{
    public class TomadorService : ITomadorService
    {
        private readonly ITomadorRespository _tomadorRepository;
        public TomadorService(ITomadorRespository tomadorRepository)
        {
            _tomadorRepository = tomadorRepository;
        }
        public Task<int> Save(TomadorDTO entity)
        {
            if (entity.id > 0)
            {
                return _tomadorRepository.Update(entity.mapToEntity());
            }
            else
            {
                return _tomadorRepository.Save(entity.mapToEntity());
            }
        }
        public List<TomadorDTO> FindAll()
        {
            return _tomadorRepository.FindAll()
                .Select(c => new TomadorDTO()
                {
                    id = c.Id,
                    tipo = c.Tipo,
                    cpfCnpj = c.CpfCnpj,
                    nomeRazaoSocial = c.NomeRazaoSocial,
                    logradouro = c.Logradouro,
                    email = c.Email,
                    numeroResidencia = c.NumeroResidencia,
                    bairro = c.Bairro,
                    cidade = c.Cidade,
                    cep = c.Cep,
                }).ToList();
        }
        public async Task<TomadorDTO> FindById(int id)
        {
            var dto = new TomadorDTO();
            return dto.mapToDTO(await _tomadorRepository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _tomadorRepository.FindById(id);
            return await _tomadorRepository.Delete(entity);
        }
    }
}
