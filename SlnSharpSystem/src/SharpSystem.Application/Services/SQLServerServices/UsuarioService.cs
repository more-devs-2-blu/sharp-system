using SharpSystem.Domain.DTO;
using SharpSystem.Domain.IRepositories.IUsuarioRepositories;
using SharpSystem.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Application.Services.SQLServerServices
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _repository.FindById(id);
            return await _repository.Delete(entity);
        }

        public List<UsuarioDTO> FindAll()
        {
            return _repository.FindAll()
                .Select(u => new UsuarioDTO()
                {
                    id = u.Id,
                    nome = u.Nome,
                    cpfcnpj = u.CFPCNPJ,
                    email = u.Email,
                    login = u.Login,
                    senha = u.Senha,
                }).ToList();
        }

        public async Task<UsuarioDTO> FindById(int id)
        {
            var dto = new UsuarioDTO();
            return dto.mapToDTO(await _repository.FindById(id));
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
    }
}
