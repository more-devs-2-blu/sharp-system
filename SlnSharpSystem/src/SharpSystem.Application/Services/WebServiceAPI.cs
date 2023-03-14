using RestSharp;
using SharpSystem.Application.Interfaces;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.IServices;
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

        public async Task SendXML(string base64, DataFormat file)
        {
            var options = new RestClientOptions("https://homologacao.atende.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);
            request.AddHeader("Authorization", base64);
            request.AddHeader("Cookie", "PHPSESSID=rodg956rbmrq2kfrn9ad44kv22; cidade=integracoes");
            request.AlwaysMultipartFormData = true;
            request.AddBody(file);
            RestResponse response = await client.ExecuteAsync(request);

            return ;
        }
    }
}
