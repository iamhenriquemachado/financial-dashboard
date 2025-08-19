using Microsoft.AspNetCore.Mvc;

namespace FinancialDashboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public async Task<IActionResult> GetMessage()
        {
            return Ok(new { StatusCode = 200, message = "server is running" });
        }
    }
}
