using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
{
    public class Merch : ControllerBase
    {
        [Route("api/shoppingcart")]
        [ApiController]
        public class ShoppingCart : ControllerBase
        {
            private readonly ApplicationDbContext _context;
            public ShoppingCart(ApplicationDbContext context)
            {
                _context = context;
            }
            //Start requests here.
            [HttpGet("merches/{id}")]
            public IActionResult GetMerchById(int id)
            {
                var merch = _context.Merches.Find(id);
                if (merch == null)
                {
                    return NotFound();
                }
                return Ok(merch);
            }
            [HttpPut("merches/{id}")]
            public IActionResult UpdateMerch(int id)
            {
                var merch = GetMerchById();
                if
    

                _context.Products.Update(merch);
                _context.SaveChanges();

            }
        }
    }
}
