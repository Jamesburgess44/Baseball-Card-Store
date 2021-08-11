using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{

    [Route("api/merches")]
    [ApiController]
    public class MerchController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public MerchController(ApplicationDbContext context)
        {
            _context = context;
        }
        //Start requests here.
        [HttpGet("{id}")]
        public IActionResult GetMerchById(int id)
        {
            var merch = _context.Merches.Find(id);
            if (merch == null)
            {
                return NotFound();
            }
            return Ok(merch);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Merch value)
        {
            _context.Merches.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpPatch("{id}")]
        public IActionResult Put(int id, [FromBody] Merch value)
        {
            var merch = _context.Merches.FirstOrDefault(merch => merch.MerchId == id);
            merch.Review = value.Review;
            merch.Rating = value.Rating;
            _context.SaveChanges();
            return Ok(merch);
        }
        [HttpDelete("{id}")]
        public IActionResult Remove (int id )
        {
            var merch = _context.Merches.Find(id);
            _context.Merches.Remove(merch);
            _context.SaveChanges();
            return Ok(merch);
        }
    }

   
}

