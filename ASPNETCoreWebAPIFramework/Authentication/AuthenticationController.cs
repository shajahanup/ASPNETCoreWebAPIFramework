using ASPNETCoreWebAPIFramework.ApplicationDbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPIFramework.Authentication
{
    [Route("api/v1/greetings")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly ApplicationDbContextClass _context;

        public AuthenticationController(ApplicationDbContextClass context) { 
            _context = context;
        
        }

        public async Task<IActionResult> GetGreetings()
        {

            var items = await _context.User.IgnoreQueryFilters().ExecuteDeleteAsync();
            return Ok(items);


        }
    }
}
