using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovieRepo.Models
{
    public class MembershipType
    {
        public Guid Id {get; set ;} 
        public float SignUpFee {get; set;}
        public float DurationInMonths {get; set;}
        public int DiscountRate {get; set;}
        public List<Customer>? Customers {get; set;}

    }
}