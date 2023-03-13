using SharpSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SharpSystem.Application.Interfaces
{
    public interface IWebServiceAPI
    {
        public string EmitirNotaFiscal(XmlSerializer xmlNotaFiscal);
        public XmlSerializer GetFile(NFSEDTO nfse);
        public XmlSerializer EmitirXMLSerializaer(NFSEDTO nfse);
    }
}
