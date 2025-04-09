namespace VendorAPI.Models.dto
{
    public class AvailabilitySlotDto
    {
        public int VendorId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}
