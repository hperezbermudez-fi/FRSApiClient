using FRSApiClient.Dtos.PegOrder;
using System.Net.Http.Headers;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using HttpClient client = new();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
        client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        var request = CreateRequest();

        var response = await ProcessRepositoriesAsync(client, request);
    }

    static async Task<object> ProcessRepositoriesAsync(HttpClient httpClient, PegOrderRequest request)
    {
        return Task.FromResult("");
    }


    static PegOrderRequest CreateRequest()
    {
        PegOrderRequest request = new()
        {
            PegDetails = new()
            {
                BSubmitted = true,
                DtDueDate = DateTime.Now.AddDays(1),
                DtSubmitted_Date = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                ICategory = 156,
                IMailingInstructions = 4,
                MailingInstructions = "UPS-2 Day",
                IOID = 8441541,
                IStatus = 797,
                VchDeliver_To = "Client/Prospect",
                VchDeliver_To_Location = "Home",
                VchDescription = "<div xmlns:dt=\"urn:schemas-microsoft-com:datatypes\">\nThe Client Development Analysis is complete and being printed.  This document will be shipped by the due date below.\n        <br>\n          Please update the Iris notes to indicate the CDA has been completed and sent.\n        </br>\n        Number of copies: 1\n        Ship Date: 10/25/2022\n        Please deliver the document to: Client/Prospect - Lon Plumpton \n        Location: Home\n        Additional Instructions:  .</div>",
                VchExternalID = "883662",
                VchNotes = ".",
                VchRegion = "FC1",
                VchSubmitted_By = "FISH-NET\\cboutwell",
                VchNum_Copies = 1,
                Recipient = new()
                {
                    Cda = "FISH-NET\\zshattuck",
                    Cdvp = "FISH-NET\\jrichardson",
                    SalesPerson = "FISH-NET\\SVU_CRM_TermOSPQ",
                    Ic = "FISH-NET\\kStanton"
                },
                RequestType = new()
                {
                    Id = 3,
                    Description = "ClientDevelopment"
                },
            },
            Attachment = new()
            {
                Attachments = new List<Attachments>()
            {
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337827/8441541_Plumpton_and_20221024_CDA.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337828/8441541_Plumpton_and_20221024_CDACL.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337829/8441541_Plumpton_and_20221024_CDAXR_Pershing-Accounts.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337831/8441541_Plumpton_and_20221024_CDASI_Pershing-Accounts.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337832/8441541_Plumpton_and_20221024_CDAXR_Edward-Jones-Accounts.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337836/8441541_Plumpton_and_20221024_CDASI_Edward-Jones-Accounts.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337837/8441541_Plumpton_and_20221024_CDAXR_Fidelity-Accounts.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337839/8441541_Plumpton_and_20221024_CDASI_Fidelity-Accounts.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337840/8441541_Plumpton_and_20221024_CDAXR_Total-Portfolio.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337843/8441541_Plumpton_and_20221024_CDASI_Total-Portfolio.pdf"),
                new Attachments("https://pegtracker.fi.com/FileRender/Render/151337844/8441541_Plumpton_and_20221024_CDAMFASummary.pdf")
            }
            }
        };

        return request;
    }
}