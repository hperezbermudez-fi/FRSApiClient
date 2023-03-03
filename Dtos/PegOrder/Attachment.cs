namespace FRSApiClient.Dtos.PegOrder
{
    public class Attachment
    { 
        public IEnumerable<Attachments> Attachments { get; set; }
        
        private int _quantity;
        public int Quantity 
        { 
            get => _quantity; 
            set 
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Quantity must be between [1,5] inclusive");
                }

                _quantity = value;
            } 
        }
    }

    public class Attachments
    {
        public Attachments()
        { 

        }
        
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