using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        // get all merch 
        [HttpGet]
        public IActionResult GetAllMerch()
        {
            var merches = _context.Merches;
            return Ok(merches);
        }
        // get merch by id TESTED
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
        // post or "add" new merch to database TESTED
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] Merch value)
        {
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            _context.Merches.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
        // update merch by id TESTED

        // delete merch by id TESTED 
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

