
﻿using RestSharp;
using SharpSystem.Application.Interfaces;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.IServices;

﻿using SharpSystem.Application.Interfaces;
using SharpSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Application.Services
{
    public class WebServiceAPI : IWebServiceAPI
    {
        public string EmitirNotaFiscal(XmlSerializer xmlNotaFiscal)
        {
            throw new NotImplementedException();
        }

        public XmlSerializer EmitirXMLSerializaer(NFSEDTO nfse)
        {
            throw new NotImplementedException();
        }

        public XmlSerializer GetFile(NFSEDTO nfse)
        {
            throw new NotImplementedException();
        }
    }
}
