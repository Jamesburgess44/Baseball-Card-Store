using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Review   
    {      

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }
        
        [ForeignKey("Merch")]
        public int MerchId { get; set; }
        public Merch Merch { get; set; }

        public string UserReview { get; set; }
        public int Rating { get; set; }
    }
}
