using Microsoft.AspNetCore.Mvc;
using FinancialDashboard.Services;
using FinancialDashboard.Entities.DTOs;
using FinancialDashboard.Entities;

namespace FinancialDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        public async Task<IActionResult> AuthenticateUser()
        {

            Message message = new Message();


            return Ok(new
            {
                message.SUCCESS_CREATED
            });
        }
    }
}
