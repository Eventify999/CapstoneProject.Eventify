using AutoMapper;
using VendorAPI.Data;
using VendorAPI.Models.dto;
using VendorAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace VendorAPI.Repository
{
    public class AvailabilityRepository : IAvailabilityRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public AvailabilityRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AvailabilitySlot>> GetSlotsByVendorId(int vendorId)
        {
            return await _context.AvailabilitySlots
                .Where(s => s.VendorId == vendorId)
                .ToListAsync();
        }

        public async Task<AvailabilitySlot> AddOrUpdateSlot(AvailabilitySlotDto dto)
        {
            var existing = await _context.AvailabilitySlots.FirstOrDefaultAsync(s =>
                s.VendorId == dto.VendorId && s.StartTime == dto.StartTime && s.EndTime == dto.EndTime);

            if (existing != null)
            {
                existing.IsAvailable = dto.IsAvailable;
                await _context.SaveChangesAsync();
                return existing;
            }

            var slot = _mapper.Map<AvailabilitySlot>(dto);
            _context.AvailabilitySlots.Add(slot);
            await _context.SaveChangesAsync();
            return slot;
        }
    }
}

