using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using SharpSystem.Application.Interfaces;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.IServices;
using System.Xml.Serialization;
=======
using SharpSystem.Domain.DTO;
using System.Xml.Serialization;
using System;
using System.Net;
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef

namespace SharpSystem.Web.Controllers
{
    public class NFSEController : Controller
    {
<<<<<<< HEAD
        private readonly INotaFicalService _notaFicalService;


        public NFSEController(INotaFicalService notaFicalService)
        {
            _notaFicalService = notaFicalService;
        }

=======
        string arquivoXMLstring = "";
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
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
<<<<<<< HEAD
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"C:\DEV2BLU\projeto final\Nova pasta", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFSEDTO));
                xmlSerializer.Serialize(stream, nfse);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
=======
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

        
>>>>>>> 382b642530529f38c9e349e12a7338fff40a45ef
    }
}
