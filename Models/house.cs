using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace turner_4200.Models
{

    public class house
    {
        //if model and database arent in sync, then integrate data migration. cannot have coed on network to have it work
        [Key]
        public int PropertyId { get; set; }

        public string HouseTenant { get; set; }
        public string Address { get; set; }

        public string PricePerTenant { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<tenant> Tenant { get; set; }
        // this works because of the key that exists on the order/tenant page
    }
}