using RestSharp;
using System.IO;
using System.Net;

internal class Program
{
    private static async Task Main(string[] args)
    {
        string Path;
        Console.WriteLine("Hello, World!");
        var options = new RestClientOptions("https://homologacao.atende.net")
        {
            MaxTimeout = -1,
        };
        var client = new RestClient(options);
        var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);

        Path = Console.ReadLine();

        request.AddHeader("Authorization", "Basic IDI1LjgyNS4zMDcvMDAwMS01MjpUZXN0ZUAyMDIz");
        request.AlwaysMultipartFormData = true;
        request.AddFile("vamodale", Path);

        RestResponse response = await client.ExecuteAsync(request);

        File.WriteAllText("/DEV2BLU/projeto final/Nova pasta/resposta4.txt", response.Content.ToString());
     
    }
}