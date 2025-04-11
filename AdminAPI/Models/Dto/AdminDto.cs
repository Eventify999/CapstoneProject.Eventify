using System.ComponentModel.DataAnnotations;

namespace AdminAPI.Models.Dto
{
    public class AdminDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
