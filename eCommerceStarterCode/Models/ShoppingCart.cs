using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
       // public int ShoppingCartId { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public int MerchId { get; set; }
        public Merch Merch { get; set; }
    }
}
