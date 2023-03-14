using RestSharp;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.IServices;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSystem.Application.Services.SQLServerServices
{
    public class NotaFiscalService : INotaFicalService
    {
        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<NFSEDTO> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<NFSEDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(NFSEDTO entity)
        {
            throw new NotImplementedException();
        }

        public async Task SendXML(string Base64, NFSEDTO objeto)
        {
            var options = new RestClientOptions("https://homologacao.atende.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);
            request.AddHeader("Authorization", Base64);
            request.AddHeader("Cookie", "PHPSESSID=rodg956rbmrq2kfrn9ad44kv22; cidade=integracoes");
            request.AlwaysMultipartFormData = true;
            request.AddXmlBody<NFSEDTO>(objeto);
            RestResponse response = await client.ExecuteAsync(request);

            return;
        }
    }
}
