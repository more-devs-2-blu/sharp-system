using Microsoft.AspNetCore.Mvc;
using SharpSystem.Application.SQLServerServices.NFSServices;
using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.DTO.UsuarioDTO;
using SharpSystem.Domain.IServices.INFSServices;
using System.Xml.Serialization;

namespace SharpSystem.Web.Controllers
{
    public class NFSEController : Controller
    {
        private readonly INotaFicaslService _notaFicalService;
        private readonly INFSEService _infseService;


        public NFSEController(INotaFicaslService notaFicalService, INFSEService infseService)
        {
            _notaFicalService = notaFicalService;
            _infseService = infseService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("notaFiscalDTO, prestador, tomador, itens, ")] NFSEDTO nfse)
        {
                if(await _infseService.Save(nfse) > 0) 
                {
                    string nameXML = _infseService.CreateXML(nfse);
                    _infseService.SendXML(nameXML, "Basic MjU4MjUzMDcwMDAxNTI6VGVzdGVAMjAyMw==");
                }
            return RedirectToAction(nameof(Index));
        }


    }
}
