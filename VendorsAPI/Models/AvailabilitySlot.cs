using System.ComponentModel.DataAnnotations;

namespace VendorAPI.Models
{
    public class AvailabilitySlot
    {
        [Key]
        public int SlotId { get; set; }

        [Required]
        public int VendorId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}
