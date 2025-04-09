using VendorAPI.Models.dto;
using VendorAPI.Models;

namespace VendorAPI.Repository
{
    public interface IAvailabilityRepository
    {
        Task<IEnumerable<AvailabilitySlot>> GetSlotsByVendorId(int vendorId);
        Task<AvailabilitySlot> AddOrUpdateSlot(AvailabilitySlotDto dto);
    }
}
