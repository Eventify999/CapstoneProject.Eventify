namespace CustomerAPI.Modals.Dto
{
    public class ServiceResponseDto
    {
        public int ResponseId { get; set; }
        public int RequestId { get; set; }
        public int VendorId { get; set; }
        public string PackageDetails { get; set; }
        public decimal PriceQuote { get; set; }
        public DateTime RespondedAt { get; set; }
        public bool IsAccepted { get; set; }

    }
}
