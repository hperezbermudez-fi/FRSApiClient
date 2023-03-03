namespace FRSApiClient.Dtos.PegOrder
{
    public class PegDetails
    {
        public bool? bSubmitted { get; set; }
        public DateTime? dtDue_Date { get; set; }
        public DateTime? dtSubmitted_Date { get; set; }
        public int? iCategory { get; set; }
        public int? iID { get; set; }
        public int? iMailingInstructions { get; set; }
        public string MailingInstructions { get; set; }
        public int? iOID { get; set; }
        public int? iStatus { get; set; }
        public string vchDeliver_To { get; set; }
        public string vchDeliver_To_Location { get; set; }
        public string vchDescription { get; set; }
        public string vchExternalID { get; set; }
        public string vchNotes { get; set; }
        public string vchRegion { get; set; }
        public string vchSubmitted_By { get; set; }
        public int? vchNum_Copies { get; set; }
        public Recipient Recipient { get; set; }
        public RequestType RequestType { get; set; }
    }
}