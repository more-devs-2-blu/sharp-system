using RestSharp;
using SharpSystem.Domain.DTO.NFSDTO;

namespace SharpSystem.Domain.IServices.INFSServices
{
    public interface INFSEService : IBaseService<NFSEDTO>
    {
        string CreateXML(NFSEDTO nfse);
        Task<RestResponse> SendXML(string NomeDoArquivo, string Base64);
    }
}
