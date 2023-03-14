using RestSharp;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
                    var options = new RestClientOptions("https://homologacao.atende.net")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest("/?pg=rest&service=WNERestServiceNFSe&cidade=integracoes", Method.Post);
            request.AddHeader("Authorization", "Basic IDI1LjgyNS4zMDcvMDAwMS01MjpUZXN0ZUAyMDIz");
            request.AlwaysMultipartFormData = true;
            request.AddXmlBody("vamodale", "/DEV2BLU/projeto final/Material coletado/folheto.txt");
            RestResponse response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        
    }
}