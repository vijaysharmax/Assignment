using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRegistration.API.Data;

namespace UserRegistration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("state/{stateId}")]
        public async Task<IActionResult> GetCitiesByState(int stateId)
        {
            var cities = await _context.Cities
                .Where(x => x.StateId == stateId)
                .ToListAsync();

            return Ok(cities);
        }
    }
}
