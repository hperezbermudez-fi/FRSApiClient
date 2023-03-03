using FRSApiClient;
using FRSApiClient.Dtos.PegOrder;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

internal class Program
{
    private static readonly HttpClient _frsHttpClient;

    public static string FrsApiBaseUrl => "https://fulfillmentrequest-qa.fi.com/api/";
    public static string PegOrderLegacyEndpoint => "Frs/peg/order/legacy";

    static Program()
    {
        var handler = new HttpClientHandler() 
        { 
            UseDefaultCredentials = true, 
            PreAuthenticate = true 
        };

        _frsHttpClient = new HttpClient(handler) 
        { 
            BaseAddress = new Uri(FrsApiBaseUrl)
        };

        _frsHttpClient.DefaultRequestHeaders.Accept.Clear();
        _frsHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        _frsHttpClient.DefaultRequestHeaders.Add("User-Agent", ".NET Console Application");
    }

    private static async Task Main()
    {
        Console.WriteLine("Posting a Peg Order from Uris");
        await PostRequestAsync(PegOrderHelper.CreatePegOrderRequestFromUris());

        Console.WriteLine("Posting a Peg Order from Pdfs Content");
        await PostRequestAsync(PegOrderHelper.CreatePegOrderRequestFromPDFs());

        Console.ReadLine();
    }

    private static async Task PostRequestAsync(PegOrderRequest pegOrderRequest)
    {
        var content = new StringContent(JsonSerializer.Serialize(pegOrderRequest), Encoding.UTF8, "application/json");
        var response = await _frsHttpClient.PostAsync(PegOrderLegacyEndpoint, content);

        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"An error has ocurred ${response.Content}");
            //Throw Exception
            return;
        }

        var resultObject = await response.Content.ReadAsStringAsync();
        Console.WriteLine(resultObject);
    }
}