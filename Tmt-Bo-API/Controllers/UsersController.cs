using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tmt_Bo_API.Data;
using Tmt_Bo_API.Entities;


namespace Tmt_Bo_API.Controllers
{
    [ApiController]
    [Route("tmt_bo_api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
           return await _context.users.ToListAsync();

            
        }

        //Tmt_Bo_API/Users/number id
        [HttpGet("{id}")]

        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.users.Find(id);

        }
    }
}

