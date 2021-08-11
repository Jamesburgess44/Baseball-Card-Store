﻿using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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


        [HttpGet("{UserId}")]
        public IActionResult GetShoppingCartByUserId(string UserId)
        {
            var ShoppingCart = _context.ShoppingCarts.Where(sc =>sc.UserId==UserId);          
            if (ShoppingCart == null)
            {
                return NotFound();
            }
            return Ok(ShoppingCart);
        }


        //add by merchId

   

        //Start requests here.
        //public IActionResult YouNameIt()
        //{
        //    return View();
        //}
    }
}


