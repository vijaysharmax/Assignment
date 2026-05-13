using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserRegistration.API.Data;
using UserRegistration.API.Models;
using UserRegistration.API.Models.RequestModels;

namespace UserRegistration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser( UserRequestModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new User
            {
                Name = request.Name,
                Gender = request.Gender,
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                ContactNo = request.ContactNo,
                StateId = request.StateId,
                CityId = request.CityId,
                Hobbies = request.Hobbies,
                PhotoPath = request.PhotoPath,
                IsTermsAccepted = request.IsTermsAccepted
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers(string? search = "")
        {
            var query = _context.Users.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.Name.Contains(search)).ToList();
            }

            return Ok(query);
        }
    }
}
