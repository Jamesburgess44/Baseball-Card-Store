using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
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
        //[HttpPut("merches/{id}")]
        //public IActionResult UpdateMerch(int id)
        //{
        //    var merch = GetMerchById();
        //    if


        //    _context.Products.Update(merch);
        //    _context.SaveChanges();

        [HttpPost]
        public IActionResult Post([FromBody] Merch value)
        {
            _context.Merches.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

    }
   
}

