using RestSharp;
using SharpSystem.Domain.DTO.NFDTO;
using SharpSystem.Domain.IServices;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public async Task SendXML(string Base64, string path, string name)
        {
            var options = new RestClientOptions("https://homologacao.atende.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);

            request.AddHeader("Authorization", Base64);
            request.AlwaysMultipartFormData = true;
            request.AddFile("vamodale", path);

            RestResponse response = await client.ExecuteAsync(request);

            File.WriteAllText( path+name+"Resposta.txt" , response.Content.ToString());
            return;
        }
    }
}
