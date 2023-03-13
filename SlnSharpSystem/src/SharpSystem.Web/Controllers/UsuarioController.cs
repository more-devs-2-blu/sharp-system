using Microsoft.AspNetCore.Mvc;
using SharpSystem.Domain.DTO;
using SharpSystem.Domain.Entities.Usuario;
using SharpSystem.Domain.IServices;
using System.Security.Cryptography.Xml;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Xml;
using SharpSystem.Domain.Entities;
using SharpSystem.Domain.Entities.NF;

namespace SharpSystem.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            Prestador prestador = new Prestador
            {
                CpfCnpj = "1231233333",
                Cidade = "Palhocaaaaaa"
            };

            NotaFiscal nf = new NotaFiscal
            {
                Prestador = prestador
            };

            XmlSerializer ins = new XmlSerializer(typeof(NotaFiscal));
            Random rnd = new Random();
            TextWriter writer = new StreamWriter(@"D:\dev\sharp-system\Teste.xml");
            ins.Serialize(writer, nf);
            writer.Close();

            CspParameters cspParams = new()
            {
                KeyContainerName = "Chave"
            };
            RSACryptoServiceProvider rsaKey = new(cspParams);

            XmlDocument xmlDoc = new()
            {
                PreserveWhitespace = true
            };
            TextReader reader = new StreamReader(@"D:\dev\sharp-system\Teste.xml");

            xmlDoc.Load(reader);

            SignedXml signedXml = new(xmlDoc)
            {
                SigningKey = rsaKey
            };
            Reference reference = new()
            {
                Uri = ""
            };
            XmlDsigEnvelopedSignatureTransform env = new();
            reference.AddTransform(env);
            signedXml.AddReference(reference);
            signedXml.ComputeSignature();
            XmlElement xmlDigitalSignature = signedXml.GetXml();
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));
            xmlDoc.Save("Teste.xml");

            return View(_service.FindAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("id, nome, cpfcnpj, email, login, senha")] UsuarioDTO usuario)
        {
            if (ModelState.IsValid)
            {
                if (await _service.Save(usuario) > 0) return RedirectToAction("Index");
            }
            return View(usuario);
        }
    }
}
