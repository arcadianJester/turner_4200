using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace turner_4200.Models
{
    public class tenant
    {
        [Key]
        public int TenantId { get; set; }
        public int PropertyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string FullName
        {
            get
            { return LastName + ", " + FirstName; }
        }

        public DateTime LeaseDate { get; set; }
        public virtual house House { get; set; }
        // databse can find the customer information on its own from the shared database
        //enable migrations statement to adjust the database is what many people have trouble with
    }
}