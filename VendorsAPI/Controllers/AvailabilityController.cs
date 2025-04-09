using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendorAPI.Models.dto;
using VendorAPI.Repository;

namespace VendorAPI.Controllers
{
    [Route("api/availability")]
    [ApiController]
    public class AvailabilityController : ControllerBase
    {
        private readonly IAvailabilityRepository _repo;
        private readonly IMapper _mapper;
        private readonly ResponseDto _response;

        public AvailabilityController(IAvailabilityRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            _response = new ResponseDto();
        }

        [HttpGet("vendor/{vendorId}")]
        public async Task<IActionResult> GetSlotsByVendor(int vendorId)
        {
            try
            {
                var result = await _repo.GetSlotsByVendorId(vendorId);
                _response.Result = result;
                _response.Message = "Slots retrieved successfully.";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return StatusCode(500, _response);
            }
        }

        [HttpPost("update")]
        public async Task<IActionResult> AddOrUpdateSlot([FromBody] AvailabilitySlotDto dto)
        {
            try
            {
                var result = await _repo.AddOrUpdateSlot(dto);
                _response.Result = result;
                _response.Message = "Slot updated successfully.";
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                return StatusCode(500, _response);
            }
        }
    }
}
