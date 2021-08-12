using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Review
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int MerchId { get; set; }
        public Merch Merch { get; set; }
        public string UserReview { get; set; }
        public int Rating { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
