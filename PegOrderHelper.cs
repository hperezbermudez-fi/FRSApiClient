using FRSApiClient.Dtos.PegOrder;

namespace FRSApiClient
{
    public class PegOrderHelper
    {
        static private PegOrderRequest _pegOrderRequest = new()
        {
            PegDetails = new()
            {
                bSubmitted = true,
                dtDue_Date = DateTime.Now.AddDays(1),
                dtSubmitted_Date = DateTime.Now.Subtract(TimeSpan.FromDays(1)),
                iCategory = 156,
                iMailingInstructions = 4,
                MailingInstructions = "UPS-2 Day",
                iOID = 8441541,
                iStatus = 797,
                vchDeliver_To = "Client/Prospect",
                vchDeliver_To_Location = "Home",
                vchDescription = "<div xmlns:dt=\"urn:schemas-microsoft-com:datatypes\">\nThe Client Development Analysis is complete and being printed.  This document will be shipped by the due date below.\n        <br>\n          Please update the Iris notes to indicate the CDA has been completed and sent.\n        </br>\n        Number of copies: 1\n        Ship Date: 10/25/2022\n        Please deliver the document to: Client/Prospect - Lon Plumpton \n        Location: Home\n        Additional Instructions:  .</div>",
                vchExternalID = "883662",
                vchNotes = ".",
                vchRegion = "FC1",
                vchSubmitted_By = "FISH-NET\\cboutwell",
                vchNum_Copies = 1,
                Recipient = new()
                {
                    Cda = "FISH-NET\\zshattuck",
                    Cdvp = "FISH-NET\\jrichardson",
                    SalesPerson = "FISH-NET\\SVU_CRM_TermOSPQ",
                    Ic = "FISH-NET\\kStanton"
                },
                RequestType = new()
                {
                    Id = RequestTypeEnumeration.ClientDevelopment,
                    Description = "ClientDevelopment"
                },
            }
        };

        static public PegOrderRequest CreatePegOrderRequestFromPDFs()
        {
            _pegOrderRequest.Attachment = new()
            {
                Quantity = 1
            };

            _pegOrderRequest.Attachment.Attachments = Directory.EnumerateFiles("PDFs", "*.pdf").Select(filePath => {
                var fileContent = File.ReadAllBytes(filePath);
                var fileName = Path.GetFileName(filePath);

                return new Attachments(fileName, Convert.ToBase64String(fileContent));
            });  

            return _pegOrderRequest;
        }

        static public PegOrderRequest CreatePegOrderRequestFromUris()
        {
            _pegOrderRequest.Attachment = new()
            {
                Attachments = new List<Attachments>()
                {
                    new Attachments("https://pegtracker.fi.com/FileRender/Render/151337827/8441541_Plumpton_and_20221024_CDA.pdf"),
                    new Attachments("https://pegtracker.fi.com/FileRender/Render/151337828/8441541_Plumpton_and_20221024_CDACL.pdf")
                },
                Quantity = 1
            };

            return _pegOrderRequest;
        }
    }
}
