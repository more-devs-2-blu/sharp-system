﻿using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.IServices
{
    public interface ISessaoService
    {
        void CriarSessaoUsuario(Usuario usuario);
        void RemoverSessaoUsuario();
        Usuario BuscarSessaoUsuario();
    }
}