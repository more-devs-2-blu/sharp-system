﻿using SharpSystem.Domain.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.DTO
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpfcnpj { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public Usuario mapToEntity()
        {
            return new Usuario
            {
                Id = id,
                Nome = nome,
                CFPCNPJ = cpfcnpj,
<<<<<<< HEAD
                //Email = email,
=======
                Email = email,
                Login = login,
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
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
<<<<<<< HEAD
                //email = usuario.Email,
                //login = usuario.Login,
                senha = usuario.Senha,
            };
        }
        public string mapTo64()
        {
            string str = cpfcnpj + senha;
            byte[] encodedBytes = Encoding.UTF8.GetBytes(str);
            string encodedString = Convert.ToBase64String(encodedBytes);
            return encodedString;
        }
=======
                email = usuario.Email,
                login = usuario.Login,
                senha = usuario.Senha,
            };
        }
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
    }
}
