using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendorAPI.Models;
using VendorAPI.Models.dto;
using VendorAPI.Repository;
using BCrypt.Net;

namespace VendorAPI.Controllers
{
    [Route("api/vendor/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IVendorRepository _repo;

        public AuthController(IVendorRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(VendorRegisterDto dto)
        {
            var existing = await _repo.GetVendorByEmail(dto.Email);
            if (existing != null)
            {
                return BadRequest("Email already Exists");
            }

            var vendor = new Vendor
            {
                BusinessName = dto.BusinessName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            await _repo.RegisterVendor(vendor);
            return Ok("Vendor registered successfully.");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(VendorLoginDto dto)
        {
            var vendor = await _repo.GetVendorByEmail(dto.Email);
            if (vendor == null || !BCrypt.Net.BCrypt.Verify(dto.Password, vendor.PasswordHash))
            {
                return Unauthorized("Invalid Credentials");
            }

            return Ok(new { message = "Login Successfull. Token issued by Auth service." });

        }

    }
}
