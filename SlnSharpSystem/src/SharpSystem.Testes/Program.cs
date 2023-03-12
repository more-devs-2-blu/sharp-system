// See https://aka.ms/new-console-template for more information
using SharpSystem.Domain.Entities;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;
using System.Security.Cryptography.Xml;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Prestador prestador = new Prestador
        {
            CpfCnpj = "123123",
            Cidade = "Palhoca"
        };

        NotaFiscal nf = new NotaFiscal
        {
            Prestador = prestador,
        };



        XmlSerializer ins = new XmlSerializer(typeof(NotaFiscal));
        TextWriter writer = new StreamWriter(@"C:\DEV2BLU\projeto final\sharp-system\SlnSharpSystem\testes\Teste.xml");
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
        TextReader reader = new StreamReader(@"C:\DEV2BLU\projeto final\sharp-system\SlnSharpSystem\testes\Teste.xml");

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
    }
}