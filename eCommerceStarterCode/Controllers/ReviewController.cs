using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/review")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
    private readonly ApplicationDbContext _context;
    public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Review value)
    {
        var userId = User.FindFirstValue("id");
        value.UserId = userId;
        _context.Reviews.Add(value);
        _context.SaveChanges();
        return StatusCode(201, value);
    }
        

    }
}
