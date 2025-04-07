    using System.ComponentModel.DataAnnotations;

namespace CustomerAPI.Modals
{
    public class ServiceResponse
    {
        [Key]
        public int ResponseId { get; set; }

        [Required]
        public int RequestId { get; set; }

        public int VendorId { get; set; } // Can be fetched from VendorAPI
        public string PackageDetails { get; set; }  
        public decimal PriceQuote { get; set; }
        public DateTime RespondedAt { get; set; }
        public bool IsAccepted { get; set; }

    }
}
