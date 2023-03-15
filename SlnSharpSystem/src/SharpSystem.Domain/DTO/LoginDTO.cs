using SharpSystem.Domain.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.DTO
{
    public class LoginDTO
    {
        public string cpfcnpj { get; set; }
        public string senha { get; set; }

        public Login mapToEntity()
        {
            return new Login
            {
                CFPCNPJ = cpfcnpj,
                Senha = senha
            };
        }

        public LoginDTO mapToDTO(Login login)
        {
            return new LoginDTO()
            {
                cpfcnpj = login.CFPCNPJ,
                senha = login.Senha,
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
