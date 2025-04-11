namespace AdminAPI.Models.Dto
{
    public class ApprovalRequestDto
    {
        public int VendorId { get; set; }
        public string Details { get; set; }
        public string DocumentsUrl { get; set; }
    }

    public class ApprovalResponseDto
    {
        public int VendorId { get; set; }
        public string Details { get; set; }
        public string DocumentsUrl { get; set; }
        public bool ApprovalStatus { get; set; }
    }

    public class ApprovalUpdateDto
    {
        public int VendorId { get; set; }
        public bool ApprovalStatus { get; set; }
    }
}