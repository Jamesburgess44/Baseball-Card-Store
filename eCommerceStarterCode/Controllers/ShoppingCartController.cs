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
    [Route("api/shoppingcart")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }


        //// Get by UserId
        //[HttpGet("{UserId}")]
        //public IActionResult Get([FromBody]ShoppingCart value)
        //{
        //    var shoppingCart = _context.ShoppingCarts;
        //    var specificUserCart = shoppingCart.Where(sc => sc.UserId == value.UserId);
        //    return Ok(specificUserCart);
        //}


        //[HttpGet("{UserId}")]
        //public IActionResult GetShoppingCartByUserId(string UserId)
        //{
        //    var ShoppingCart = _context.ShoppingCarts.Where(sc =>sc.UserId==UserId);          
        //    if (ShoppingCart == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(ShoppingCart);
        //}
        [HttpPost, Authorize]
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            var userId = User.FindFirstValue("id");
            value.UserId = userId;
            try
            {
                _context.ShoppingCarts.Add(value);
                _context.SaveChanges();
                return StatusCode(201, value);
            }
            catch
            { 
                return StatusCode(400, value); 
            }
                        
        }
        [HttpDelete("{MerchId}/{UserId}")]
        public IActionResult Remove(int MerchId, string UserId)
        {
            var deleteProduct = _context.ShoppingCarts.Where(dp => dp.UserId == UserId && dp.MerchId == MerchId).SingleOrDefault();
            if (deleteProduct == null)
            {
                return NotFound();
            }
            _context.ShoppingCarts.Remove(deleteProduct);
            _context.SaveChanges();
            return Ok(deleteProduct);
        }
        [HttpGet(), Authorize]
        public IActionResult GetUserCart()
        {
            var userId = User.FindFirstValue("id");
            var userCart = _context.ShoppingCarts.Include(uc => uc.Merch).ThenInclude(ac => ac.User).Where(uc => uc.UserId == userId).ToList().
                Select(e => new { merchName = e.Merch.Name, merchPrice = e.Merch.Price });
            if (userCart == null)
            {
                return NotFound();
            }
            return Ok(userCart);
        }

        //add by merchId



        //Start requests here.
        //public IActionResult YouNameIt()
        //{
        //    return View();
        //}
    }
}


