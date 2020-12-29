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
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUsers>>> GetUsers(){
                var _userobj = _context.Users.ToListAsync();
                return await _userobj;
        }

        //api/Users/id
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUsers>> GetUsers(long id){
                var _userobj = _context.Users.FindAsync(id);
                return await _userobj;
        }
    }
}