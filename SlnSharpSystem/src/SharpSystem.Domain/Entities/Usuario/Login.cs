using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.Entities.Usuario
{
    public class Login
    {
        public string CFPCNPJ { get; set; }
<<<<<<< HEAD
        public string Senha { get; set; }
        public string mapTo64()
        {
            string str = CFPCNPJ + Senha;
            byte[] encodedBytes = Encoding.UTF8.GetBytes(str);
            string encodedString = Convert.ToBase64String(encodedBytes);
            return encodedString;
        }
    }

=======
        public string Senha { get; set; } 
    }
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
}
