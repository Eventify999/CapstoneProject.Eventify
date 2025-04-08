﻿namespace CustomerAPI.Modals.Dto
{
    public class ServiceRequestDto
    {
        public int RequestId { get; set; }
        public int CustomerId { get; set; }
        public int EventRequirementId { get; set; }
        public DateTime RequestedAt { get; set; }
        public string Status { get; set; }

    }
}
