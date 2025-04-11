using AuthAPI.Models.Dto;
using AuthAPI.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthApiController : ControllerBase
    {
        private readonly IAuthService _authService;
        protected ResponseDto _response;

        public AuthApiController(IAuthService authService)
        {
            _authService = authService;
            _response = new();
        }



        //[HttpPost("register")]
        //public async Task<IActionResult> Register([FromBody] RegistrationRequestDto model)
        //{
        //    var errorMessage = await _authService.Register(model);
        //    if (!string.IsNullOrEmpty(errorMessage)) 
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message= errorMessage;
        //        return BadRequest(_response);
        //    }
        //    return Ok(_response);
        //}


        [HttpPost("register/customer")]
        public async Task<IActionResult> RegisterCustomer([FromBody] RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model, "Customer");
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("register/vendor")]
        public async Task<IActionResult> RegisterVendor([FromBody] RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model, "Vendor");
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }

        [HttpPost("register/admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegistrationRequestDto model)
        {
            var errorMessage = await _authService.Register(model, "Admin");
            if (!string.IsNullOrEmpty(errorMessage))
            {
                _response.IsSuccess = false;
                _response.Message = errorMessage;
                return BadRequest(_response);
            }
            return Ok(_response);
        }



        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto model)
        {
            var loginResponse = await _authService.Login(model);
            if (loginResponse.User == null)
            {
                _response.IsSuccess = false;
                _response.Message = "Username or password is incorrect";
                return BadRequest(_response);
            }
            _response.Result = loginResponse;
            return Ok(_response);
        }

        //[HttpPost("AssignRole")]
        //public async Task<IActionResult> AssignRole([FromBody] RegistrationRequestDto model)
        //{
        //    var assignRoleSuccessful = await _authService.AssignRole(model.Email, model.Role.ToUpper());

        //    if (!assignRoleSuccessful)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = "Error Encountered";
        //        return BadRequest(_response);
        //    }
        //    return Ok(_response);

        //}



    }
}
