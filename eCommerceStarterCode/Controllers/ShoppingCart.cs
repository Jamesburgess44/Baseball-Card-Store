using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Controllers
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
        public IActionResult YouNameIt()
        {
            return View();
        }
    }
}




public class ExamplesController : ControllerBase
{
    