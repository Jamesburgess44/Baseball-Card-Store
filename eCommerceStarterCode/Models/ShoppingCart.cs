using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Merch")]
        public int MerchId { get; set; }
        public Merch Merch { get; set; }
        public int Quantity { get; set; }
    }
}
