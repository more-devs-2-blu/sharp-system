using SharpSystem.Domain.DTO.UsuarioDTO;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Domain.IServices;
using System.Text;

namespace SharpSystem.Application.Services.SQLServerServices
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Save(UsuarioDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
        public List<UsuarioDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(u => new UsuarioDTO()
                {
                    id = u.Id,
                    nome = u.Nome,
                    cpfcnpj = u.CFPCNPJ,
                    senha = u.Senha,
                }).ToList();
        }
        public async Task<UsuarioDTO> FindById(int id)
        {
            var dto = new UsuarioDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }
        public static string DecodeFromBase64(string str)
        {
            byte[] encodedBytes = Convert.FromBase64String(str);
            string decodedString = Encoding.UTF8.GetString(encodedBytes);
            return decodedString;
        }
        public static string EncodeToBase64(string str)
        {
            byte[] encodedBytes = Encoding.UTF8.GetBytes(str);
            string encodedString = Convert.ToBase64String(encodedBytes);
            return encodedString;
        }

    }
}
