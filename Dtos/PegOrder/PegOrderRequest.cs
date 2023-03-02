namespace FRSApiClient.Dtos.PegOrder
{
    public class PegOrderRequest
    {
        public PegDetails PegDetails { get; set; }
        public Attachment Attachment { get; set; }
        public Submiter Submiter { get; set; }
    }
}
