using RestSharp;
using SharpSystem.Domain.DTO.NFSDTO;
using SharpSystem.Domain.IRepositories.INFSRespositories;
using SharpSystem.Domain.IServices.INFSServices;
using System.Xml.Serialization;

namespace SharpSystem.Application.SQLServerServices.NFSServices
{
    public class NFSEService : INFSEService
    {
        private readonly INFSERespository _nfseRespository;
        public NFSEService(INFSERespository nfseRespository)
        {
            _nfseRespository = nfseRespository;
        }
        public Task<int> Save(NFSEDTO entity)
        {
            if (entity.id > 0)
            {
                return _nfseRespository.Update(entity.mapToEntity());
            }
            else
            {
                return _nfseRespository.Save(entity.mapToEntity());
            }
        }
        public List<NFSEDTO> FindAll()
        {
            return _nfseRespository.FindAll()
                .Select(c => new NFSEDTO()
                {
                    id = c.Id,
                    notaFiscalDTO = new NotaFiscalDTO()
                    {
                        id = c.NotaFiscal.Id,
                        valorTotal = c.NotaFiscal.ValorTotal
                    },
                    prestador = new PrestadorDTO()
                    {
                        id = c.Prestador.Id,
                        cpfCnpj = c.Prestador.CpfCnpj,
                        cidade = c.Prestador.Cidade,
                    },
                    tomador = new TomadorDTO()
                    {
                        id = c.Tomador.Id,
                        tipo = c.Tomador.Tipo,
                        cpfCnpj = c.Tomador.CpfCnpj,
                        nomeRazaoSocial = c.Tomador.NomeRazaoSocial,
                        logradouro = c.Tomador.Logradouro,
                        email = c.Tomador.Email,
                        numeroResidencia = c.Tomador.NumeroResidencia,
                        bairro = c.Tomador.Bairro,
                        cidade = c.Tomador.Cidade,
                        cep = c.Tomador.Cep,

                    },
                    itens = new ItensDTO()
                    {
                        id = c.Itens.Id,
                        listaDTO = new ListaDTO()
                        {
                            id = c.Itens.lista.Id,
                            tributaMunicipioPrestador = c.Itens.lista.TributaMunicipioPrestador,
                            codigoLocalPrestacaoServico = c.Itens.lista.CodigoLocalPrestacaoServico,
                            codigoItemListaServico = c.Itens.lista.CodigoItemListaServico,
                            descritivo = c.Itens.lista.Descritivo,
                            aliquotaItemListaServico = c.Itens.lista.AliquotaItemListaServico,
                            situacaoTributaria = c.Itens.lista.SituacaoTributaria,
                            valorTributavel = c.Itens.lista.ValorTributavel,
                        }
                    }
                }).ToList();
        }
        public async Task<NFSEDTO> FindById(int id)
        {
            var dto = new NFSEDTO();
            return dto.mapToDTO(await _nfseRespository.FindById(id));
        }
        public async Task<int> Delete(int id)
        {
            var entity = await _nfseRespository.FindById(id);
            return await _nfseRespository.Delete(entity);
        }
        public string CreateXML(NFSEDTO nfse)
        {
            string nomeArquivo = DateTime.Now.ToString().Replace(@"/", "").Replace(@" ", "").Replace(@":", "") + ".xml";
            using (StreamWriter stream = new StreamWriter(Path.Combine(@"D:\Documents\XML", nomeArquivo)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(NFSEDTO));
                xmlSerializer.Serialize(stream, nfse);
            }
            return nomeArquivo;
        }
        public async Task<RestResponse> SendXML(string NomeDoArquivo, string Base64)
        {
            var options = new RestClientOptions("https://homologacao.atende.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);
            string path = "D:\\Documents\\XML\\" + NomeDoArquivo;
            request.AddHeader("Authorization", Base64);
            request.AlwaysMultipartFormData = true;
            request.AddFile("XML", $"D:\\Documents\\XML\\{NomeDoArquivo}");

            RestResponse response = await client.ExecuteAsync(request);

            File.WriteAllText("D:\\Documents\\XML\\Respostas\\" + NomeDoArquivo, response.Content.ToString());

            string pedro = "Pedro";
            return response;
        }
    }
}
