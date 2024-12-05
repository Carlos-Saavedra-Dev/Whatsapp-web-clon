using ChatApp.Application.DTOs;
using ChatApp.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController: ControllerBase
    {

        private readonly IUserService userService;
        public AuthenticationController( IUserService _userService) 
        {
            userService = _userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto registerDto)
        {
            try
            {
                if (registerDto == null || String.IsNullOrEmpty(registerDto.PhoneNumber)
                    || String.IsNullOrEmpty(registerDto.Password) || String.IsNullOrEmpty(registerDto.Username))
                {
                    return StatusCode(400, new { Message = "Parameters missing" });
                }

                await userService.RegisterUser(registerDto);

                return NoContent();
                
            
            }catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return Problem(ex.ToString());
            }
        }

    }

    
}
