<<<<<<< HEAD
﻿using SharpSystem.Domain.DTO.NFDTO;
=======
﻿using SharpSystem.Domain.DTO;
>>>>>>> afe7de9308e1f37d67ce3c556ec893dbbea30b45
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Domain.IServices
{
    public interface INotaFicalService : IBaseService<NFSEDTO>
    {
        public Task SendXML(string Base64, string path, string name);
    }
}
