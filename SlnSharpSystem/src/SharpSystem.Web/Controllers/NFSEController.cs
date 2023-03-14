using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using SharpSystem.Domain.DTO;
using System.Xml.Serialization;

namespace SharpSystem.Web.Controllers
{
    public class NFSEController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public async Task<ActionResult> CreateXML(NFSEDTO nfse)
        {
            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "") + ".xml";
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"D:\dev\sharp-system", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFSEDTO));
                xmlSerializer.Serialize(stream, nfse);
                var options = new RestClientOptions("https://homologacao.atende.net")
                {
                    MaxTimeout = -1,
                };
                var client = new RestClient(options);
                var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);
                request.AddHeader("Authorization", "Basic IDI1LjgyNS4zMDcvMDAwMS01MjpUZXN0ZUAyMDIz");
                request.AddHeader("Cookie", "PHPSESSID=rodg956rbmrq2kfrn9ad44kv22; cidade=integracoes");
                request.AlwaysMultipartFormData = true;
                request.AddFile("vamodale", "/C:/Users/pedro/OneDrive/Área de Trabalho/DIARIO.txt");
                RestResponse response = await client.ExecuteAsync(request);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
