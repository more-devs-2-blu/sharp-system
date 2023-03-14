using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpSystem.Application.Interfaces;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.IServices;
using System.Xml.Serialization;

namespace SharpSystem.Web.Controllers
{
    public class NFSEController : Controller
    {
        private readonly INotaFicalService _notaFicalService;


        public NFSEController(INotaFicalService notaFicalService)
        {
            _notaFicalService = notaFicalService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateXML(NFSEDTO nfse)
        {
            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "") + ".xml";
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"C:\DEV2BLU\projeto final\Nova pasta", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFSEDTO));
                xmlSerializer.Serialize(stream, nfse);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
