namespace FRSApiClient.Dtos.PegOrder
{
    public class Attachment
    { 
        public IEnumerable<Attachments> Attachments { get; set; }
        public int Quantity => Attachments?.Count() ?? 0;
    }

    public class Attachments
    {
        public Attachments(string uri) => Uri = uri;

        public Attachments(string fileName, string base64FileContent)
        { 
            FileName = fileName;
            Base64FileContent = base64FileContent;
        }

        public string FileName { get; private set; }
        public string Base64FileContent { get; private set; }
        public string Uri { get; private set; }
    }
}