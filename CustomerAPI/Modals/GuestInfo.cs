using System.ComponentModel.DataAnnotations;

namespace CustomerAPI.Modals
{
    public class GuestInfo
    {
        [Key]
        public int GuestId { get; set; }

        [Required]
        public int EventRequirementId { get; set; }

        public string GuestName { get; set; }
        public string Email { get; set; }
        public string MealPreference { get; set; }
    }
}
