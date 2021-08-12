using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        [HttpPost]
        public IActionResult Post([FromBody] Review value)
    {
        _context.Reviews.Add(value);
        _context.SaveChanges();
        return StatusCode(201, value);
    }
        

    }
}
