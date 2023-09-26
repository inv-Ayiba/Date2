using System.Collections.Immutable;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    // [ApiController]
    // [Route("api/[controller]")] // /api/users
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
           
        }
        
        [HttpGet]
        //  public ActionResult<IEnumerable<AppUser>> GetUsers()
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync() ;
            return users;
            // return Ok(users);
        }
        // [AllowAnonymous]
        [HttpGet("{id}")]
        
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            
            Type a2 = id.GetType();
            return await _context.Users.FindAsync(id);
        }
    }
}