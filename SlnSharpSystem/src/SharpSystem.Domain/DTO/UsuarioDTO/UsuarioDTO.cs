using SharpSystem.Domain.Entities.Usuario;
using System.Text;

namespace SharpSystem.Domain.DTO.UsuarioDTO
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpfcnpj { get; set; }
        public string senha { get; set; }
        public bool senhaValida(string senhaRecebida)
        {
            return senha == senhaRecebida;
        }
        public Usuario mapToEntity()
        {
            return new Usuario
            {
                Id = id,
                Nome = nome,
                CFPCNPJ = cpfcnpj,
                Senha = senha
            };
        }
        public UsuarioDTO mapToDTO(Usuario usuario)
        {
            return new UsuarioDTO()
            {
                id = usuario.Id,
                nome = usuario.Nome,
                cpfcnpj = usuario.CFPCNPJ,
                senha = usuario.Senha,
            };
        }
        public string mapTo64()
        {
            string str = $"{cpfcnpj}:{senha}";
            byte[] encodedBytes = Encoding.UTF8.GetBytes(str);
            string encodedString = Convert.ToBase64String(encodedBytes);
            return encodedString;
        }
    }
}
