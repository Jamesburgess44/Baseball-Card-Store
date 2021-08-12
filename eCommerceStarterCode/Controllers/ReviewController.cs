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
        //private readonly ApplicationDbContext _context;
        //public ReviewController(ApplicationDbContext context)
        //{
        //    [HttpPost("{id}")]
        //    public IActionResult Post(int id, [FromBody] Review value)
        //    {
        //        var merch = _context.Reviews.FirstOrDefault(merch => merch.MerchId == id);
        //        re.Review = value.Review;
        //        merch.Rating = value.Rating;
        //        _context.SaveChanges();
        //        return Ok(merch);
        //    }
        //}

    }
}
