using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.DTO.UsuarioDTO;
using System.Xml.Serialization;

namespace SharpSystem.Web.Controllers
{
    public class NFSEController : Controller
    {
        private readonly INotaFiscalService _notaFicalService;


        public NFSEController(INotaFiscalService notaFicalService)
        {
            _notaFicalService = notaFicalService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        string arquivoXMLstring = "";
        [HttpPost]
        public ActionResult CreateXML(NFSEDTO nfse)
        {
            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "") + ".xml";
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"D:\dev\sharp-system", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFSEDTO));
                // Cria uma string do XML
                var sw = new StringWriter();
                xmlSerializer.Serialize(sw, nfse);
                arquivoXMLstring = sw.ToString();


                xmlSerializer.Serialize(stream, nfse);

                return RedirectToAction(nameof(Index));
                //return View(arquivoXMLstring);
            }
        }

    }
}
