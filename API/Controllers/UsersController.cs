using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    //Web Route. The Client will have to specify this route to access this API.
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        //We have access to your DB context just by using the _context (Just like with Selenium webdriver)
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //It's going to return a list. IEnumerable is the appropriate list for this.
            // It's Async as It makes it instantly more scaleable. 
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = _context.Users.Find(id);
            //The quote marks and the curly brackets inside is the root parameter that refers to a DB value
            return await _context.Users.FindAsync(id);
        }
    }
}