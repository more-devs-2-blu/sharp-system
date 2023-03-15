using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharpSystem.Application.Interfaces;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.DTO.NFDTO;
using SharpSystem.Domain.IServices;
using System.Buffers.Text;
using System.IO;
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
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"D:\Documents\XML", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFSEDTO));
                xmlSerializer.Serialize(stream, nfse);
                return RedirectToAction(nameof(Index));
            }
            UsuarioDTO usuario = new UsuarioDTO();
            string senhaBase64 = usuario.mapTo64();

            _notaFicalService.SendXML($"{senhaBase64}", "", "");
            return View();
        }
    }
}
