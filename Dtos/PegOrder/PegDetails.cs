namespace FRSApiClient.Dtos.PegOrder
{
    public class PegDetails
    {
        public bool BSubmitted { get; set; }
        public DateTime DtDueDate { get; set; }
        public DateTime DtSubmitted_Date { get; set; }
        public int ICategory { get; set; }
        public int IID { get; set; }
        public int IMailingInstructions { get; set; }
        public string MailingInstructions { get; set; }
        public int IOID { get; set; }
        public int IStatus { get; set; }
        public string VchDeliver_To { get; set; }
        public string VchDeliver_To_Location { get; set; }
        public string VchDescription { get; set; }
        public string VchExternalID { get; set; }
        public string VchNotes { get; set; }
        public string VchRegion { get; set; }
        public string VchSubmitted_By { get; set; }
        public int VchNum_Copies { get; set; }
        public Recipient Recipient { get; set; }
        public RequestType RequestType { get; set; }
    }
}