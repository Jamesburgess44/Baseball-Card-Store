using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

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
            try
            {
                _context.Reviews.Add(value);
                _context.SaveChanges();
                return StatusCode(201, value);
            }
            catch
            {
                return StatusCode(400, value);
            }
    }
        [HttpGet("{merchid}")]
        public IActionResult GetReviewById(int merchId)
        {
            var reviews = _context.Reviews.Where(r => r.MerchId == merchId).Include(r => r.User).Include(r => r.Merch).
                 Select(r => new { merchId = r.MerchId, name = r.Merch.Name, userId = r.UserId, rating = r.Rating, userreview = r.UserReview, userName = r.User.UserName });
            if (reviews == null)
            {
                return NotFound();
            }
            return Ok(reviews);
        }
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var reviews = _context.Reviews;
            return Ok(reviews);
        }
    }
}
